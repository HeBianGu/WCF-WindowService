using HeBianGu.BaseLayer.WCF.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Module.WCF.DataBase.Oracle
{
    public class DataBaseService
    {
        public List<MeasureData> GetAll()
        {
            List<MeasureData> result = new List<MeasureData>();

            string connstring =
         "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-0DLE8DV)(PORT=1521))" +
         "(CONNECT_DATA=(SID=orcl)));User Id=HeBianGu;Password=admin;";//这个也可以放到Web.Config中。
            using (OracleConnection conn = new OracleConnection(connstring))
            {
                conn.Open();
                string sql = "select * from MEASUREDATAS t";

                using (OracleCommand comm = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Console.WriteLine(rdr.GetString(0) + " - " + rdr.GetString(1) + " - " + rdr.GetString(2));

                            MeasureData m = new MeasureData();
                            m.ID = rdr.GetString(0);
                            m.IDCODE = rdr.GetString(1);
                            m.DETAIL = rdr.GetString(2);
                            m.State = rdr.GetString(3);

                            result.Add(m);
                        }
                    }
                }
            }

            return result;

        }
    }
}
