using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class FullScreenText : Form
    {
        Registration reg;
        public FullScreenText(Registration reg)
        {
            InitializeComponent();
            this.reg = reg;
        }

        private void FullScreenText_Load(object sender, EventArgs e)
        {
            GridHeader.Columns[0].HeaderText = "Регистрација на возило: " + reg.Name;
            GridHeader.Columns[1].HeaderText = "Модел на возило: " + reg.CarModel;
            foreach (InfoText info in reg.Info)
            {
                var index = this.DataGrid.Rows.Add();
                DataGrid.Rows[index].Cells[0].Value = info.Datetime;
                DataGrid.Rows[index].Cells[1].Value = info.Kilometers;
                DataGrid.Rows[index].Cells[2].Value = info.Text;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
