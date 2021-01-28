using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSystem
{
    class DBClass
    {
        public String databaseConnection()
        {
            string ConString = "datasource=localhost; username=root; password=; database= coopdb";
            return ConString;
        }
    }
}
