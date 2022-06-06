using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Project_MES.Control.Global
{
    internal class Global_DataStorage
    {
        public static string ClientName = Dns.GetHostName();
        public static string ClientIP = "ClientIP"; // Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
    }
}
