using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using System.Web;
using System.Xml;
using System.Text;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class TestPost
    {
        [TestMethod]
        public void TestPostMethod()
        {

            string url = "http://LocalHost:22999/";
            try
            {
                Console.WriteLine("Post Method TestPost");
                string parms = "122";
                string method = "GetData";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + "/" + method + "/" + parms);
                request.Method = "POST";
                request.ContentType = "text/plain";
                Stream requestStram = request.GetRequestStream();
                requestStram.Close();
                HttpWebResponse myResponse = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string ReqResult = reader.ReadToEnd();
                Debug.WriteLine(ReqResult);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            Console.Read();
        }

        [TestMethod]
        public void TestPostMethodNoParam()
        {

            string url = "http://LocalHost:22999/";
            try
            {
                Console.WriteLine("Post Method TestPost");
                string method = "GetAllMeasureData";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + "/" + method );
                request.Method = "POST";
                request.ContentType = "text/plain";
                Stream requestStram = request.GetRequestStream();
                requestStram.Close();
                HttpWebResponse myResponse = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string ReqResult = reader.ReadToEnd();
                Debug.WriteLine(ReqResult);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            Console.Read();
        }

    }
}
