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
            Log4Servcie.Instance.Info(string.Format("You entered: {0}", value));

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
            Log4Servcie.Instance.Info(string.Format(MethodInfo.GetCurrentMethod().Name));

            try
            {

                string result = DataService.Instance.GetAll().ToString();
                return result;
            }
            catch (Exception ex)
            {
                Log4Servcie.Instance.Error(ex);
                Log4Servcie.Instance.Error(ex.InnerException);
                return ex.InnerException.ToString();
            }



        }


        public string Hello()
        {
            Log4Servcie.Instance.Info(string.Format(MethodInfo.GetCurrentMethod().Name));

            string result = DataService.Instance.GetAll().ToString();

            return result;
        }

    }
}
