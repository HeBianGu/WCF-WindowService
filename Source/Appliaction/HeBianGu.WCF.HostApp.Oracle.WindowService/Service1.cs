using HeBianGu.Domian.WCF.ServiceManager;
using HeBianGu.GeneralLayer.WCF.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.WCF.HostApp.Oracle.WindowService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

            // Todo ：初始化 
            string exeFileFullPath = Assembly.GetEntryAssembly().Location;
            string exeName = System.IO.Path.GetFileNameWithoutExtension(exeFileFullPath);
            string binPath = System.IO.Path.GetDirectoryName(exeFileFullPath);

            binPath = System.IO.Path.GetDirectoryName(binPath);

            string logFilePath = System.IO.Path.GetDirectoryName(binPath);

            //  初始化日志
            Log4Servcie.Instance.InitLogger(logFilePath, System.Diagnostics.Process.GetCurrentProcess().ProcessName);


        }

        protected override void OnStart(string[] args)
        {
            ServiceRegisterService.Instance.RegisterCodeDemo();

        }

        protected override void OnStop()
        {
            ServiceRegisterService.Instance.CancelRegister();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }
        protected override void OnContinue()
        {
            base.OnContinue();
        }
        protected override void OnShutdown()
        {
            base.OnShutdown();
        }
    }
}
