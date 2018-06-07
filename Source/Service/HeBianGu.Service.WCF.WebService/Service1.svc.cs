using HeBianGu.Domain.WCF.DataManager;
using HeBianGu.GeneralLayer.WCF.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HeBianGu.Service.WCF.WebService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
      

        public string GetData(string value)
        {
            WcfLogService.Instance.LogStartMethod(MethodInfo.GetCurrentMethod().Name);

            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetAllMeasureData()
        {
            WcfLogService.Instance.LogStartMethod(MethodInfo.GetCurrentMethod().Name);

            try
            {
                string result = DataService.Instance.GetAll().ToString();

                WcfLogService.Instance.LogResultMethod(result);

                return result;
            }
            catch (Exception ex)
            {
                WcfLogService.Instance.LogResultMethod(ex.ToString());

                return ex.InnerException.ToString();
            }



        }


        public string Hello()
        {
            WcfLogService.Instance.LogStartMethod(MethodInfo.GetCurrentMethod().Name);

            string result = "Hello:" + DateTime.Now.ToString();

            WcfLogService.Instance.LogResultMethod(result);

            return "Hello:"+DateTime.Now.ToString();
          
           
        }

        public string HelloDB()
        {
            WcfLogService.Instance.LogStartMethod(MethodInfo.GetCurrentMethod().Name);

            try
            {
                string result = DataService.Instance.GetAll().ToString();

                WcfLogService.Instance.LogResultMethod(result);

                return result;
            }
            catch (Exception ex)
            {
                WcfLogService.Instance.LogResultMethod(ex.ToString());
                return ex.ToString();
            }

        }

    }

}
