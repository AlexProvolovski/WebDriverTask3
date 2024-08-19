using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTask3
{
    public class ConfigLoader
    {
        public static NameValueCollection LoadProperties(string environment)
        {
            return ConfigurationManager.AppSettings;
        }
    }
}
