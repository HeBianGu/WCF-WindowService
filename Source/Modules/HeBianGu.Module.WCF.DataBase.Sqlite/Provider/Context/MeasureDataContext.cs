#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) **********, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2018/6/5 14:18:50 
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

namespace HeBianGu.Module.WCF.DataBase.Sqlite
{
    public class MeasureDataContext : DbContext
    {
        public DbSet<MeasureData> MeasureDatas { get; set; }

        public MeasureDataContext() : base(DBConfiger.GetCon, true)
        {

        }
    }
}
