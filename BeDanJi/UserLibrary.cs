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
            string path = Path.Combine(Environment.CurrentDirectory, userName);
            if (Directory.Exists(path))
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
            string path = Path.Combine(Environment.CurrentDirectory, userName);
            string data = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, data, Encoding.UTF8);
        }
    }
}
