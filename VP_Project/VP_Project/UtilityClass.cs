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
        public static List<Owner> Owners { get; set; } = new List<Owner>(); 
        public static string BaseFolderRegs { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "/data/regs/";
        public static string BaseFolderOwners { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "/data/owners/";
        public UtilityClass() { }
        public static bool DoesRegExist(string name)
        {
            foreach (Registration reg in Regs)
            {
                if(reg.Name == name) return true;
            }
            return false;
        }
        public static T Deserialize<T>(string path)
        {
            T? obj;
            using (FileStream fs = File.OpenRead(path))
            {
                obj = JsonSerializer.Deserialize<T>(fs);
            }
            return obj;
        }
        public static bool Serialize<T>(T obj, string path)
        {
            string folder = string.Empty;
            if (obj.GetType() == typeof(Registration)) folder = BaseFolderRegs;
            else if (obj.GetType() == typeof(Owner)) folder = BaseFolderOwners;
            using (FileStream fs = File.Create(folder + path + ".json"))
            {
                JsonSerializer.Serialize(fs, obj);
            }
            if (File.Exists(folder + path + ".json")) return true;
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
        public static void AllowAlphabetLettersOnly(TextBox TB)
        {
            int caretpos = TB.SelectionStart;
            if (!String.IsNullOrWhiteSpace(TB.Text))
            {
                foreach (char c in TB.Text.ToCharArray())
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(c.ToString(), @"^[a-zA-Z0-9 ]+$"))
                    {
                        TB.Text = TB.Text.Replace(c.ToString(), "");
                        TB.SelectionStart = caretpos - 1;
                    }
                }
            }
        }
        public static bool DoesOwnerExist(string ID)
        {
            foreach (Owner o in Owners)
            {
                if (o.ID == ID) return true;
            }
            return false;
        }
        public static Owner GetOwner(string name)
        {
            return Owners.Find(x => x.Name == name);
        }
    }
}