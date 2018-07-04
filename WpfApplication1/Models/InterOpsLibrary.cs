using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WpfApplication1.Models
{
    class InterOpsLibrary
    {
        #region "serializeJson"

        public static void SendProfile()
        {
            
            var menu = new Menu();
            var sendRadial = menu._radialMenu();
            var json = new JavaScriptSerializer().Serialize(sendRadial);
            System.IO.File.WriteAllText(@"Models\ProfilesLibrary.json", json);
            
        }

        #endregion
    }
}
