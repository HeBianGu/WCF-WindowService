#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) **********, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2018/6/5 14:18:37 
 * 文件名：DemoService 
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Module.WCF.DataBase.Sqlite
{
    class MeasureDataService
    {
        public List<MeasureData> GetAll()
        {
            using (MeasureDataContext context = new MeasureDataContext())
            {
                //var c = from l in context.MeasureDatas
                //        orderby l.Date
                //        select l;

                //if (c == null) return null;

                var c = context.MeasureDatas;

                if (c == null) return null;

                return c.ToList();
            }
        }
    }
}
