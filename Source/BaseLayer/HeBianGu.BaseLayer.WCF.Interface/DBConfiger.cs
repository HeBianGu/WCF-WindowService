using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.BaseLayer.WCF.Interface
{
    /// <summary> 数据库连接配置 </summary>
    public class DBConfigerService
    {
        public static DBConfigerService Instance = new DBConfigerService();

        /// <summary> 索引 </summary>
        public const string ConString = "SqliteTest";

        private string _connectStr;
        /// <summary> 说明 </summary>
        public string ConnnectStr
        {
            get { return _connectStr; }
            set { _connectStr = value; }
        }

        public DBConfigerService()
        {
            // Todo ：取文档下面的数据库 
            //_connectStr = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            //    "HealthyCottage", "HealthyCottageDataBase.s3db");

            _connectStr = Path.Combine(@"F:\GitHub\WCF-WindowService\Product\Dll", "HealthyCottageDataBase.s3db");
            
        }
    }
}
