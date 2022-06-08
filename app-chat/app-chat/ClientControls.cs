using app_chat.Controler;
using server;
using server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace app_chat
{
    public class ClientControls
    {
        public delegate void CallMessageBox(string message, bool check = false);
        public delegate void ShowMessageBox(string message, bool check = false);
        public delegate void GetUName(List<String> listchat);
        //public CallMessageBox callMessageBox;

        public convert cvt = new convert();
        public Messages ms = new Messages();

        public IPEndPoint IP;
        public Socket client;

        public List<String> listchat = new List<String>();

        public static void catchs(string message, bool check)
        {

        }
        public static void catchs1(string message, bool check)
        {

        }
        public static void catchs2(List<String> listchat)
        {

        }


        public CallMessageBox callMessageBox = new CallMessageBox(catchs);
        public ShowMessageBox ShowMessage = new ShowMessageBox(catchs1);
        public GetUName getUName = new GetUName(catchs2);

        public void Send(string action)
        {
            ms.action = action;

            client.Send(cvt.Serialize(ms)); 
        }
        public void SendLogin(string nameUser, string password)
        {
            ms.action = "login";

            //add data
            ms.user.UserName = nameUser;
            ms.user.Password = password;

            client.Send(cvt.Serialize(ms));
        }
        public void SendRegister(string user, string pass)
        {
            ms.action = "register";

            //add data
            ms.user.UserName=user;
            ms.user.Password=pass;

            client.Send(cvt.Serialize(ms));
        }
        public void SendJoinChat(string uname)
        {
            ms.action = "join chat";

            ms.Uname = uname;

            client.Send(cvt.Serialize(ms));
        }
        public void SendOutChat(string uname)
        {
            ms.action = "out chat";

            ms.Uname = uname;

            client.Send(cvt.Serialize(ms));
        }
        public void SendChat( string text, string Uname)
        {
            ms.action = "chat";

            //add data
            ms.text = text;
            ms.Uname = Uname;

            client.Send(cvt.Serialize(ms));
        }

        public void SendChangePass( string newPass)
        {
            ms.action = "change password";

            //add data
            ms.user.Password = newPass;
            

            client.Send(cvt.Serialize(ms));

        }
        public void SendChangeInfo(string name, string note, DateTime dayofbirth) { 
            ms.action = "update info";

            //add data
            ms.user.Name = name;
            ms.user.Note = note;
            ms.user.DayOfBirth = dayofbirth;


            client.Send(cvt.Serialize(ms));
        }

        public bool Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
                callMessageBox("Connect thành công", true);
            }
            catch
            {
                callMessageBox("Không kết nối được server");
               
            }

            //tạo cái luồng để lắng nghe
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            return true;
        }
        public void Close()
        {
            client.Close();
        }
        
        public void Receive()
        {
            try
            {
                while (true)
                {
                    
                    byte[] data = new byte[1024 * 1000];
                    client.Receive(data);

                    Messages _ms = new Messages();


                    _ms = (Messages)cvt.Deserialize(data);

                    switch (_ms.action)
                    {
                        case "login":
                            if (_ms.text == "success")
                            {
                                ms.user = _ms.user;

                                callMessageBox("Bạn đã đăng nhập thành công !!!", true);
                                //loginForm.Close();
                            }
                            else if (_ms.text == "logged in")
                            {
                                callMessageBox("Bạn đã đăng nhập vào hệ thống rồi, vui lòng không đăng nhập lại !!!");
                            }

                            else
                            {
                                callMessageBox("Đăng nhập thất bại! Tài khoản " + _ms.user.UserName + " không tồn tại! ");
                            }

                            break;
                        //case "logout":
                        //    if (_ms.text == "success")
                        //    {
                        //       // callMessageBox("Đăng xuất thành công", true);
                        //    }
                        //    else
                        //    {
                        //       // callMessageBox("Đã xảy ra lỗi, kiểm tra lại code trên server");
                        //    }

                        //    break;
                        case "register":
                            if (_ms.text == "success")
                            {
                                callMessageBox("Đăng ký thành công", true);
                            }

                            else if (_ms.text == "exited")
                            {
                                callMessageBox("Tài khoản đã tồn tại !");
                            }

                            else
                            {
                                callMessageBox("Tài khoản đăng ký thất bại!");
                            }

                            break;
                        case "join chat":
                            if (_ms.text == "success")
                            {
                               

                                callMessageBox("Bạn đã tham gia chat all", true);
                              
                                listchat = _ms.listchat;
                                Console.WriteLine(_ms.listchat[0]);
                                getUName(_ms.listchat);
                                
                                //btnSend.Enabled = true;

                                //ms.user = new User();
                                //list_user.Add(_ms.Uname);

                                //ListViewItem lvitem = new ListViewItem(_ms.Uname);

                                // lvitem.SubItems.Add(_ms.Uname);

                                // UserLv.Items.Add(lvitem);

                                //list_user.Add(_ms.Uname);
                                //UserLv.Items.Add(text);
                            }
                            else
                            {
                                callMessageBox("Tham gia chat all không thành công!");
                            }

                            break;

                        case "out chat":
                            if (_ms.text == "success")
                            {
                                callMessageBox("Bạn đã rời khỏi nhóm chat!", true);
                                listchat = _ms.listchat;
                                getUName(_ms.listchat);
                                //btnSend.Enabled = false;


                            }
                            else
                            {
                                callMessageBox("Lỗi, xem lại code ở server!");
                            }

                            break;
                        case "chat":
                            string msg = _ms.Uname + ": " + _ms.text;
                            ShowMessage(msg, false);
                            break;
                        case "change password":
                            if (_ms.text == "success")
                            {
                                callMessageBox("Đổi mật khẩu thành công");
                            }
                            else if (_ms.text == "not existed")
                                callMessageBox("Tài khoản không tồn tại !");
                            else
                                callMessageBox("Đổi mật khẩu thất bại !");
                            break;
                        case "update info":
                            if (_ms.text == "success")
                            {
                                ms.user = _ms.user;
                                callMessageBox("Cập nhật thông tin thành công");
                            }
                            else
                            {
                                callMessageBox("Cập nhật thông tin thất bại");
                            }
                            break;

                        default:
                            break;

                    }
                }
            }
            catch
            {
                Close();
            }
        }
    }
}
