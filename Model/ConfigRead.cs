using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace AppConfigV2.Model
{
    public class ConfigRead
    {
        public string GetServer()
        {
            return ConfigurationManager.AppSettings["server"];
        }
        public string GetDatabase()
        {
            return ConfigurationManager.AppSettings["database"];
        }
        public string GetConnection1()
        {
            return ConfigurationManager.AppSettings["Connection1"];
        }
        public string GetConnection2()
        {
            return ConfigurationManager.AppSettings["Connection2"];
        }
    }
}
