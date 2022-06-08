using app_chat.Controler;
using server.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

        }

        ChatSocketDbContext db = new ChatSocketDbContext();

        convert cvt = new convert();


        IPEndPoint IP;
        Socket server;
        List<User> listUser = new List<User>();
        List<String> listchat = new List<String>();
        List<Socket> list_client = new List<Socket>();  //danh sách các client đã connect
        List<Socket> list_client_login = new List<Socket>();    // danh sách các client đã login <= đã connect
        List<Socket> list_client_chat = new List<Socket>();     // danh sách các client đã join chat <= đã login


        public void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        list_client.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            string text = "Máy chủ đang lắng nghe ip 127.0.0.1 và cổng 9999";
            string text1 = "Máy chủ đang chạy... ";
            ServeLv.Items.Add(text);
            ServeLv.Items.Add(text1);
            listen.IsBackground = true;
            listen.Start();

        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                Messages ms = new Messages();
                User temp = null;

                while (true)
                {

                    byte[] data = new byte[cvt.buffer];
                    int rec = client.Receive(data);

                    ms = (Messages)cvt.Deserialize(data);

                    switch (ms.action)
                    {
                        case "login":
                            temp = db.Users.Where(e => e.UserName == ms.user.UserName && e.Password == ms.user.Password).SingleOrDefault();
                            if (temp != null)
                            {
                                if (!list_client_login.Contains(client))
                                {
                                    list_client_login.Add(client);
                                    Console.WriteLine(list_client_login[0]);

                                    //Console.WriteLine((ms.Uname == "" ? ms.user.UserName : ms.Uname) + " dang nhap thanh cong");

                                    string text = (ms.Uname == "" ? ms.user.UserName : ms.Uname) + " dang nhap thanh cong";


                                    ServeLv.Items.Add(text);
                                    listUser.Add(ms.user);

                                    AddUser(ms.user);

                                    //thay đổi trang thái thành công và gửi lại client thông báo
                                    ms.text = "success";
                                    ms.user = temp;
                                    Send(client, ms);

                                }
                                else
                                {
                                    string text = ("dang nhap that pai");
                                    ServeLv.Items.Add(text);
                                    ms.text = "logged in";
                                    Send(client, ms);
                                }
                            }
                            else
                            {
                                //Console.WriteLine("dang nhap that bai !;  Tai khoan" + ms.user.UserName + " khong ton tai !");
                                string text = "dang nhap that bai !;  Tai khoan" + ms.user.UserName + " khong ton tai !";
                                ServeLv.Items.Add(text);

                                //thay đổi trang thái thất bại và gửi lại client thông báo
                                ms.text = "failure";
                                Send(client, ms);

                            }
                            break;
                        case "logout":
                            try
                            {
                                //xóa khỏi list chat
                                if (list_client_chat.Contains(client))
                                    list_client_chat.Remove(client);

                                ////xóa khỏi list login
                                //if (list_client_login.Contains(client))
                                //    list_client_login.Remove(client);

                                for (int i = 0; i < list_client_login.Count; i++)
                                {
                                    if (list_client_login[i] == client)
                                    {
                                        list_client_login.RemoveAt(i);
                                        listUser.RemoveAt(i);

                                    }

                                }
                                //if (listUser.Contains(ms.user))
                                //{
                                //    listUser.Remove(ms.user);
                                //    RemoveUser(ms.user);

                                //}


                                string text = "Tai khoan: " + ms.user.UserName + " da dang xuat!";
                                ServeLv.Items.Add(text);
                                LoadListView(listUser);


                                //thay đổi trang thái thất bại và gửi lại client thông báo
                                //  ms.text = "success";
                                //Send(client, ms);
                            }
                            catch
                            {
                                //thay đổi trang thái thất bại và gửi lại client thông báo
                                ms.text = "failure";
                                Send(client, ms);
                            }
                            break;
                        case "register":
                            temp = db.Users.Where(e => e.UserName == ms.user.UserName).SingleOrDefault();
                            if (temp == null)
                            {
                                try
                                {
                                    ms.user.Name = "";
                                    db.Users.Add(ms.user);
                                    db.SaveChanges();

                                    string text = "Tai khoan moi duoc dang ky: " + ms.user.UserName;

                                    ServeLv.Items.Add(text);
                                    ms.text = "success";
                                    Send(client, ms);
                                }
                                catch
                                {
                                    //thay đổi trang thái thất bại và gửi lại client thông báo
                                    string text = "Dang ky that bai ";
                                    ServeLv.Items.Add(text);
                                    ms.text = "failure";
                                    Send(client, ms);
                                }
                            }
                            else
                            {
                                //thay đổi trang thái tồn tại và gửi lại client thông báo
                                string text = "Tai khoan da ton tai ";
                                ServeLv.Items.Add(text);
                                ms.text = "existed";
                                Send(client, ms);
                            }
                            break;
                        case "join chat":
                            if (!list_client_chat.Contains(client) && list_client_login.Contains(client))
                            {
                                list_client_chat.Add(client);

                                string text = ms.user.UserName + " da tham gia chat voi ten la: " + ms.Uname;

                                ServeLv.Items.Add(text);

                                //thay đổi trang thái thành công và gửi lại client thông báo

                                listchat.Add(ms.Uname);


                                ms.listchat = listchat;
                                ms.text = "success";
                                Send(client, ms);

                            }
                            else
                            {
                                //thay đổi trang thái thất bại và gửi lại client thông báo
                                ms.text = "failure";
                                Send(client, ms);
                            }
                            break;

                        case "out chat":
                            try
                            {
                                if (list_client_chat.Contains(client) && list_client_login.Contains(client))
                                {

                                    list_client_chat.Remove(client);

                                    string text = ms.user.UserName + " da roi chat ";
                                    ServeLv.Items.Add(text);

                                    listchat.Remove(ms.Uname);


                                    //thay đổi trang thái thành công và gửi lại client thông báo

                                    ms.listchat = listchat;
                                    ms.text = "success";
                                    Send(client, ms);


                                }
                            }
                            catch
                            {
                                //thay đổi trang thái thất bại và gửi lại client thông báo
                                ms.text = "failure";
                                Send(client, ms);
                            }
                            break;

                        case "chat":
                            foreach (Socket item in list_client_chat)
                            {
                                if (item != null && item != client)
                                    Send(item, ms);
                            }
                            break;
                        case "update info":
                            temp = db.Users.Where(e => e.UserName == ms.user.UserName).SingleOrDefault();
                            if (temp != null)
                            {
                                try
                                {
                                    temp.Name = ms.user.Name;
                                    temp.Note = ms.user.Note;
                                    temp.DayOfBirth = ms.user.DayOfBirth;
                                    db.SaveChanges();


                                    string text = "Tai khoan: " + ms.user.UserName + " cap nhat thong tin thanh cong";

                                    ServeLv.Items.Add(text);


                                    //thay đổi trang thái thành công và gửi lại client thông báo
                                    ms.text = "success";
                                    ms.user = temp;
                                    Send(client, ms);
                                }
                                catch
                                {

                                    string text = "Tai khoan: " + ms.user.UserName + " cap nhat thong tin khong thanh cong";

                                    ServeLv.Items.Add(text);

                                    //thay đổi trang thái thất bại và gửi lại client thông báo
                                    ms.text = "failure";
                                    Send(client, ms);
                                }

                            }
                            else
                            {

                                string text = "Tai khoan: " + ms.user.UserName + " Khong ton tai";

                                ServeLv.Items.Add(text);

                                //thay đổi trang thái không tồn tại và gửi lại client thông báo
                                ms.text = "not existed";
                                Send(client, ms);
                            }
                            break;
                        case "change password":
                            temp = db.Users.Where(e => e.UserName == ms.user.UserName).SingleOrDefault();
                            if (temp != null)
                            {
                                try
                                {
                                    temp.Password = ms.user.Password;
                                    db.SaveChanges();


                                    string text = "Tai khoan: " + ms.user.UserName + " doi mat khau thanh cong";
                                    string text1 = "=> tu dong dang xuat !!";

                                    ServeLv.Items.Add(text);
                                    ServeLv.Items.Add(text1);


                                    //xóa khỏi list chat
                                    if (list_client_chat.Contains(client))
                                        list_client_chat.Remove(client);

                                    //xóa khỏi list login
                                    if (list_client_login.Contains(client))
                                        list_client_login.Remove(client);

                                    //thay đổi trang thái thất bại và gửi lại client thông báo
                                    ms.text = "success";
                                    Send(client, ms);
                                }
                                catch
                                {

                                    string text = "Tai khoan: " + ms.user.UserName + " doi mat khau khong thanh cong";

                                    ServeLv.Items.Add(text);

                                    //thay đổi trang thái thất bại và gửi lại client thông báo
                                    ms.text = "failure";
                                    Send(client, ms);
                                }

                            }
                            else
                            {
                                string text = "Tai khoan: " + ms.user.UserName + " Khong ton tai";

                                ServeLv.Items.Add(text);


                                //thay đổi trang thái không tồn tại và gửi lại client thông báo
                                ms.text = "not exited";
                                Send(client, ms);
                            }
                            break;

                        default:
                            break;

                    }
                }
            }
            catch
            {
                string text = "Đã xảy ra lỗi khi nhận data từ client, đóng kết nối client";
                ServeLv.Items.Add(text);
                list_client.Remove(client);
                list_client_login.Remove(client);
                list_client_chat.Remove(client);
                client.Close();
            }

        }

        void Send(Socket client, Messages ms)
        {
            if (client != null)
            {
                client.Send(cvt.Serialize(ms));
            }
        }


        public void Close()
        {

            string text1 = "Máy chủ đã tắt... ";
            ServeLv.Items.Add(text1);
            Thread.Sleep(3000);
            server.Close();

        }


        private void LoadListView(List<User> user)
        {
            this.userLv.Items.Clear();
            foreach (User username in user)
            {
                AddUser(username);
            }


        }


        void AddUser(User user)
        {
            ListViewItem lvitem = new ListViewItem(user.UserName);
            userLv.Items.Add(lvitem);
        }
        void RemoveUser(User user)
        {

            ListViewItem lvitem = new ListViewItem(user.UserName);
            userLv.Items.Remove(lvitem);

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ServeLv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void DisConBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
