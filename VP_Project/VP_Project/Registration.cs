using System;
using System.Collections.Generic;
using System.Text;

namespace VP_Project
{
    [Serializable]
    public class Registration
    {
        public string Name {  get; set; }
        public string CarModel { get; set; }
        public string Owner {  get; set; }
        public List<InfoText> Info {  get; set; }
        public Registration() 
        {
            Name = "";
            CarModel = "";
            Owner = "";
            Info = new List<InfoText>();
        }
        public Registration(string name, string carModel, string owner)
        {
            Name = name;
            CarModel = carModel;
            Owner = owner;
            Info = new List<InfoText>();
        }
        public Registration(Registration r)
        {
            Name = r.Name;
            CarModel = r.CarModel;
            Owner = r.Owner;
            Info = new List<InfoText>(r.Info);
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine("Сопственик: " + Owner);
            ret.AppendLine("Модел на возило: " + CarModel);
            ret.AppendLine();
            foreach(var info in Info)
            {
                ret.AppendLine(info.ToString());
                ret.AppendLine();
            }
            return ret.ToString();
        }

        public void AddComment(InfoText info)
        {
            Info.Add(info);
        }
    }
}
