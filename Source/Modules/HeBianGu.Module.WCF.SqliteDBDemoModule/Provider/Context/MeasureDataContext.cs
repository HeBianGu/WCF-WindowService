#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) 长虹智慧健康有限公司, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[李海军]   时间：2018/6/5 14:18:50 
 * 文件名：DemoContext 
 * 说明：
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using HeBianGu.BaseLayer.WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Module.WCF.SqliteDBDemoModule
{
    public class MeasureDataContext : DbContext
    {
        public DbSet<MeasureData> MeasureDatas { get; set; }

        public MeasureDataContext() : base(DBConfiger.GetCon, true)
        {

        }
    }
}
