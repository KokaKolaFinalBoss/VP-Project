using System;
using System.Collections.Generic;
using System.Text;

namespace VP_Project
{
    [Serializable]
    public class InfoText
    {
        public string Text {  get; set; }
        public DateTime Datetime {  get; set; }
        public int Kilometers {  get; set; }
        public InfoText() 
        {
            Text = string.Empty;
            Datetime = DateTime.Now;
            Kilometers = 0;
        }
        public InfoText(string t, DateTime dt, int k)
        {
            Text = t;
            Datetime = dt;
            Kilometers = k;
        }
        public override string ToString()
        {
            return Datetime.ToString() + Environment.NewLine + Text + Environment.NewLine + "Изминати километри: " + Kilometers.ToString() + "km";
        }
    }
}
