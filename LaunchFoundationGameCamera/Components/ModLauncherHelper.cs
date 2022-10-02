using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchFoundationGameCamera.Components
{
    internal class ModLauncherHelper
    {
        public static bool ROTTR_IsDirectX11()
        {
            var graphicsKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Crystal Dynamics\Rise of the Tomb Raider\Graphics");
            
            if(graphicsKey != null && graphicsKey.GetValue("EnableDX12") is object enableDX12)
            {
                graphicsKey.Close();

                // Return true when DirectX 12 is disabled
                return !Convert.ToBoolean(enableDX12);
            }

            return false;
        }

        public static bool SOTTR_IsDirectX11()
        {
            var graphicsKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Eidos Montreal\Shadow of the Tomb Raider\Graphics");

            if (graphicsKey != null && graphicsKey.GetValue("EnableDX12") is object enableDX12)
            {
                graphicsKey.Close();

                // Return true when DirectX 12 is disabled
                return !Convert.ToBoolean(enableDX12);
            }

            return false;
        }
    }
}
