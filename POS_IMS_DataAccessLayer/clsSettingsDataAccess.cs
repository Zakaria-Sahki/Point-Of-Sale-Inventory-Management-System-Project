using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POS_IMS_DataAccessLayer
{
    

    public class clsSettingsDataAccess {


        static public string ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ToString();
    }
}
