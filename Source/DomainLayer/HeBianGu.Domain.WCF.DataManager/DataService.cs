using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeBianGu.BaseLayer.WCF.Tool;
using HeBianGu.Module.WCF.DataBase.Oracle;

namespace HeBianGu.Domain.WCF.DataManager
{
    public class DataService
    {
        public static DataService Instance = new DataService();

        DataBaseService _dataBaseService = new DataBaseService();

        public string GetAll()
        {
            var collection = _dataBaseService.GetAll().First();

            return collection.JsonSerialize();
        }
    }
}
