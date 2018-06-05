﻿using System;
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
    }
}
