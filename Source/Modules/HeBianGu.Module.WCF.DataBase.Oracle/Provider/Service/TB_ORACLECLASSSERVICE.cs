#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) **********, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2018/6/7 17:38:19 
 * 文件名：Class1 
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

namespace HeBianGu.Module.WCF.DataBase.Oracle.Provider.Service
{
    class TB_ORACLECLASSSERVICE
    {

        public List<TB_ORACLECLASS> GetAll()
        {
            using (TB_ORACLECLASSCONTEXT context = new TB_ORACLECLASSCONTEXT())
            {
                var c = context.Collections;

                if (c == null) return null;

                return c.ToList();
            }
        }
    }
}
