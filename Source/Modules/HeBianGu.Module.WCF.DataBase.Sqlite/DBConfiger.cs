#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) **********, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2018/6/5 14:22:40 
 * 文件名：Class1 
 * 说明：
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using HeBianGu.BaseLayer.WCF.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Module.WCF.DataBase.Sqlite
{
    /// <summary> 数据库连接配置 </summary>
    internal class DBConfiger
    {

        /// <summary> 索引 </summary>
        public const string ConString = "SqliteTest";


        /// <summary> 连接对象 </summary>
        public static DbConnection GetCon
        {
            get
            {

                string v = DBConfigerService.Instance.ConnnectStr;

                v = "Data Source=" + v.Replace(@"\\", @"\") + ";";

                SQLiteConnection conn = new SQLiteConnection(v);

                return conn;
            }

        }

    }
}
