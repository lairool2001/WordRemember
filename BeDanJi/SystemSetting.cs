using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BeDanJi
{
    [Serializable]
    public class SystemSetting
    {
        static readonly string path = Path.Combine(Environment.CurrentDirectory, "systemSetting");
        public static SystemSetting systemSetting = new SystemSetting();
        public static void loadSystemSetting()
        {
            if (File.Exists(path))
            {
                systemSetting = JsonConvert.DeserializeObject<SystemSetting>(File.ReadAllText(path));
            }
            else
            {
                systemSetting = new SystemSetting();
            }
        }
        public void save()
        {
            string data = JsonConvert.SerializeObject(systemSetting);
            File.WriteAllText(data, path);
        }
        public string defaultUserName = "defaultUser";
    }
}
