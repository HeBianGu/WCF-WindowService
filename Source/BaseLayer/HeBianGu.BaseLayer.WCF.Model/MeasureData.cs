using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.BaseLayer.WCF.Model
{
    /// <summary> 测量数据 </summary>
    public class MeasureData
    {
        private string _id;
        /// <summary> 唯一标识 </summary>
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _idCode;
        /// <summary> idcode </summary>
        public string IDCODE
        {
            get { return _idCode; }
            set { _idCode = value; }
        }

        private string _detail;
        /// <summary> 序列化存储测量的详细信息 </summary>
        public string DETAIL
        {
            get { return _detail; }
            set { _detail = value; }
        }

        private string _date;
        /// <summary> 日期 </summary>
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }


        private string _state = "0";
        /// <summary> 上传状态 </summary>
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }


    }
}
