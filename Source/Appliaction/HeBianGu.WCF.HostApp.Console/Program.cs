using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using HeBianGu.Domian.WCF.ServiceManager;
using System.Reflection;
using HeBianGu.GeneralLayer.WCF.Logger;
using HeBianGu.GeneralLayer.WCF.WebService;

namespace HeBianGu.WCF.HostApp.Console
{
    class Program
    {


        //static ServiceHost 

        static void Main(string[] args)
        {
            try
            {
                // Todo ：初始化 
                string exeFileFullPath = Assembly.GetEntryAssembly().Location;
                string exeName = System.IO.Path.GetFileNameWithoutExtension(exeFileFullPath);
                string binPath = System.IO.Path.GetDirectoryName(exeFileFullPath);

                binPath = System.IO.Path.GetDirectoryName(binPath);

                string logFilePath = System.IO.Path.GetDirectoryName(binPath);

                //  初始化日志
                Log4Servcie.Instance.InitLogger(logFilePath, System.Diagnostics.Process.GetCurrentProcess().ProcessName);


                ServiceRegisterService.Instance.RegisterConfigDemo();
                


            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            System.Console.Read();

            System.Console.ReadKey();
        }


        ///// <summary> 根据类型字典和端口注册服务 </summary>
        //public static void AddService(Dictionary<Type, Type> serviceTypes)
        //{
        //    string endpointAddress = string.Empty;

        //    string tName = string.Empty;

        //    foreach (var item in serviceTypes)
        //    {
        //        tName = item.Key.Name.Substring(1);

        //        endpointAddress = string.Format(WcfConfiger.RomoteFormat, WcfConfiger.Instance.IP, WcfConfiger.Instance.Port, tName);

        //        ServiceHost host = new ServiceHost(item.Value, new Uri(endpointAddress));

        //        WSHttpBinding wsHttpBinding = new WSHttpBinding();
        //        wsHttpBinding.MaxBufferPoolSize = int.MaxValue;
        //        wsHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        //        wsHttpBinding.ReceiveTimeout = new TimeSpan(1, 0, 0);
        //        wsHttpBinding.Security = new System.ServiceModel.WSHttpSecurity();
        //        wsHttpBinding.Security.Mode = SecurityMode.None;
        //        host.AddServiceEndpoint(item.Key, wsHttpBinding, string.Empty);

        //        ServiceMetadataBehavior behavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();

        //        if (behavior == null)
        //        {
        //            behavior = new ServiceMetadataBehavior();
        //            behavior.HttpGetEnabled = true;
        //            host.Description.Behaviors.Add(behavior);
        //        }
        //        else
        //        {
        //            behavior.HttpGetEnabled = true;
        //        }

        //        DataContractSerializerOperationBehavior dataContractBehavior = host.Description.Behaviors.Find<DataContractSerializerOperationBehavior>()
        //                    as DataContractSerializerOperationBehavior;

        //        if (dataContractBehavior != null)
        //        {
        //            dataContractBehavior.MaxItemsInObjectGraph = int.MaxValue;
        //        }

        //        host.Open();
        //        serviceHosts.Add(host);
        //    }
        //}
    }

    public class WcfConfiger
    {
        private WcfConfiger()
        {

        }
        public static WcfConfiger Instance = new WcfConfiger();

        /// <summary> 服务端IP </summary>
        public string IP = "localhost";
        //public string IP = "127.0.0.1";

        /// <summary> 通信端口号 </summary>
        public string Port = "22889";

        /// <summary> 服务名 </summary>
        public string SvcName;

        /// <summary> 连接地址规则 </summary>
        public static string RomoteFormat = "http://{0}:{1}/{2}";
    }
}
