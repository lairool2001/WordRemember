using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BeDanJi
{
    [Serializable]
    public class UserLibrary
    {
        public static UserLibrary nowUserLibrary;
        public string userName;
        public List<QandA> qAndAList = new List<QandA>();
        public static UserLibrary loadFromName(string userName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, SystemStrings.user, userName + "." + SystemStrings.user);
            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<UserLibrary>(File.ReadAllText(path));
            }
            else
            {
                return null;
            }
        }
        public void save()
        {
            string userFolder = Path.Combine(Environment.CurrentDirectory, "user");
            string path = Path.Combine(userFolder, userName + ".user");
            if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "user")))
            {
                Directory.CreateDirectory(userFolder);
            }
            string data = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, data, Encoding.UTF8);
        }
    }
}
