using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1: ");
            string hostName = Dns.GetHostName();
            Console.WriteLine("Ten may: " + hostName);
            IPHostEntry ip = Dns.GetHostEntry(hostName);
            int ipNo = 0;
            foreach (IPAddress ipAdd in ip.AddressList)
                Console.WriteLine("IP thu " + ++ipNo + " la: " + ipAdd.ToString());
            Console.WriteLine();

            Console.WriteLine("Bai 2: ");
            Console.Write("Nhap IP hoac ten mien: ");
            string host = Console.ReadLine();
            IPHostEntry domainName = Dns.GetHostEntry(host);
            Console.WriteLine("Ten mien: " + domainName.HostName);
            foreach (string s in domainName.Aliases)
                Console.WriteLine("Bi danh: " + s);
            foreach (IPAddress i in domainName.AddressList)
                Console.WriteLine("IP: " + i);
            Console.ReadLine();
        }
    }
}
