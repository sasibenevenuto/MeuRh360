using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.General
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }
    public class ConnectionStrings
    {

        public string MeuRh360 { get; set; }
    }

}
