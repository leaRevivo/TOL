using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOL.Models
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings
        {
            get; set;
        }


    }
    public class ConnectionStrings
    {
        public string ConnectionString { get; set; }
    }
}
