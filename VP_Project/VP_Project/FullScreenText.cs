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
        object sent;
        public FullScreenText(object sent)
        {
            InitializeComponent();
            this.sent = sent;
        }

        private void FullScreenText_Load(object sender, EventArgs e)
        {
            if(sent.GetType() == typeof(Registration)) 
            {
                Registration reg = (Registration)sent;
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

            else if(sent.GetType() == typeof(Owner)) 
            {
                Owner o = (Owner)sent;
                DataGrid.Columns[2].Visible = false;
                DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGrid.Columns[1].HeaderText = "Модел на возило";
                DataGrid.Columns[0].HeaderText = "Регистрација";
                GridHeader.Columns[0].HeaderText = "Име и презиме: " + o.Name;
                GridHeader.Columns[1].HeaderText = "Контакт број: " + o.Number;
                foreach(Registration reg in o.GetRegList())
                {
                    var index = this.DataGrid.Rows.Add();
                    DataGrid.Rows[index].Cells[0].Value = reg.Name;
                    DataGrid.Rows[index].Cells[1].Value = reg.CarModel;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
