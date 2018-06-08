using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IP:192.169.1.19");
            Console.WriteLine("Port:22999");

            string url = "http://192.168.1.19:22999/";

            try
            {
                Console.WriteLine("Post Method TestPost");
                string method = "GetAllMeasureData";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + "/" + method);
                request.Method = "POST";
                request.ContentType = "text/plain";
                Stream requestStram = request.GetRequestStream();
                requestStram.Close();
                HttpWebResponse myResponse = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string ReqResult = reader.ReadToEnd();
                Console.WriteLine(ReqResult);
                Console.WriteLine("调用成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();
        }
    }
}
