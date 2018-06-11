#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) **********, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2018/6/7 17:29:30 
 * 文件名：OracleClass 
 * 说明：
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.BaseLayer.WCF.Model
{
   public class TB_ORACLECLASS
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

        private string _state = "0";
        /// <summary> 上传状态 </summary>
        public string STATE
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
