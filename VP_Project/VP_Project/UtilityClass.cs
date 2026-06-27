using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace VP_Project
{
    internal class UtilityClass
    {
        public static List<Registration> Regs { get; set; } = new List<Registration>();
        public static string BaseFolder { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "/data/";
        public UtilityClass() { }
        public static bool DoesRegExist(string name)
        {
            foreach (Registration reg in Regs)
            {
                if(reg.Name == name) return true;
            }
            return false;
        }
        public static Registration Deserialize(string path)
        {
            Registration reg = null;
            using (FileStream fs = File.OpenRead(path))
            {
                reg = JsonSerializer.Deserialize<Registration>(fs);
            }
            return reg;
        }
        public static bool Serialize(Registration reg)
        {
            using (FileStream fs = File.Create(BaseFolder + reg.Name + ".json"))
            {
                JsonSerializer.Serialize(fs, reg);
            }
            if (File.Exists(BaseFolder + reg.Name + ".json")) return true;
            else return false;
        }
        public static string FormatRegName(string s)
        {
            s = Regex.Replace(s, @"\s", "");
            return s.ToUpper();
        }
        public static Registration GetRegistration(string name)
        {
            return Regs.Find(x => x.Name == name);
        }
    }
}