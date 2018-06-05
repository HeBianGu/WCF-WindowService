using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.BaseLayer.WCF.Tool
{
    public static class JsonSerializeService
    {
        public static string JsonSerialize(this object obj)
        {
            if (obj == null) return null;

            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public static T JsonDeSerialize<T>(this object obj) where T : class
        {
            if (obj == null) return default(T);

            return Newtonsoft.Json.JsonConvert.DeserializeObject(obj.ToString()) as T;
        }
    }
}
