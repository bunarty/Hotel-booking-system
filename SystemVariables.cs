using Bay_View_Hotel.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay_View_Hotel
{
    public static class SystemVariables
    {
        public static bool IsLoggedIn { get; set; }
        public static Staff LoggedInUser { get; set; }
        public static string ConnectionString { get; set; }
    }
}
