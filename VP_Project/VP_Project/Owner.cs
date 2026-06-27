using System;
using System.Collections.Generic;
using System.Text;

namespace VP_Project
{
    [Serializable]
    public class Owner
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public Owner() 
        {
            Name = "";
            Email = "";
            ID = "0";
            Number = "";
            Address = "";
        }
        public Owner(string name, string email, string iD, string number, string address)
        {
            Name = name;
            Email = email;
            ID = iD;
            Number = number;
            Address = address;
        }
        public List<Registration> GetRegList()
        {
            List<Registration> reglist = new List<Registration>();
            foreach(Registration reg in UtilityClass.Regs)
            {
                if(reg.Owner.ID == ID) reglist.Add(reg);
            }
            return reglist;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Матичен број: " + ID);
            sb.AppendLine("Е-Пошта: " + Email);
            sb.AppendLine("Тел. број: " + Number);
            sb.AppendLine("Адреса: " + Address);
            sb.Append("Регистрирани возила: ");
            foreach (Registration reg in GetRegList())
            {
                sb.Append(reg.Name + ", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
