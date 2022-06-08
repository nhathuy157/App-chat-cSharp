using server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    public class SubSocket
    {
       public Socket socket;
        public User user;

        public SubSocket(Socket socket , User user)
        {
            this.socket = socket;
            this.user  = user;
        }
    }
}
