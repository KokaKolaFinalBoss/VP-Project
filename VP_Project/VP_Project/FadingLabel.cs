using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fadinglabel
{
    public partial class FadingLabel : Label
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rc = this.ClientRectangle;
            StringFormat fmt = new StringFormat(StringFormat.GenericTypographic);
            using (var br = new SolidBrush(this.ForeColor))
            {
                pe.Graphics.DrawString(this.Text, this.Font, br, rc, fmt);
            }
        }
    }
}
