using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WpfApplication1.ViewModels;

namespace WpfApplication1.Models
{
    class InterOpsLibrary
    {
        private static string filePath = Path.Combine(Environment.CurrentDirectory, @"Models\Profiles.json");
        private static RadialMenuViewModel BaseRadialMenu()
        {
            var rm= new RadialMenuViewModel();
            rm.B1= new ButtonViewModel() {Name = "Load Element", Shortcut = "LO",IconPath = @"\Icons\LoadF.png", Tooltip = "Cargar Elementos"};
            rm.B2=new ButtonViewModel() { Name = "Copy Element", Shortcut = "CO", IconPath = @"\Icons\LoadF.png", Tooltip = "Copiar Elementos" };
            rm.B3=new ButtonViewModel() { Name = "Window", Shortcut = "WN", IconPath = @"\Icons\LoadF.png", Tooltip = "Cargar Elementos" };
            rm.B4=new ButtonViewModel() { Name = "Door", Shortcut = "DR", IconPath = @"\Icons\LoadF.png", Tooltip = "Cargar Elementos" };
            rm.B5=new ButtonViewModel() { Name = "Column", Shortcut = "CL", IconPath = @"\Icons\LoadF.png", Tooltip = "Cargar Elementos" };
            return rm;
        }

        private static List<RadialMenuViewModel> Profiles()
        {
            var counter = 0;
            var radialProfiles = new List<RadialMenuViewModel>();
            while (counter<2)
            {
                radialProfiles.Add(BaseRadialMenu());
                counter += 1;
            }

            return radialProfiles;
        }
        #region "serializeJson"

        public static void SendProfile()
        {
            
            var sendRadial = Profiles();
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file,sendRadial);
            }
            
            
        }

        #endregion

        #region "GetProfiles from Json"
        
        public static RadialMenuViewModel getProfile1()
        {
            string json = File.ReadAllText(filePath);
            var Radialmenus = JsonConvert.DeserializeObject<List<RadialMenuViewModel>>(json);

            return Radialmenus[0];
        }
        

        #endregion
    }
}
