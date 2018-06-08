using HeBianGu.Domain.WCF.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Test.WCF.OracleConsoleApp
{
    class Program
    {
       
            static void Main(string[] args)
            {
                try
                {
                    var collection = DataService.Instance.GetAll();

                    foreach (var item in collection)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.Read();
            }
       
    }
}
