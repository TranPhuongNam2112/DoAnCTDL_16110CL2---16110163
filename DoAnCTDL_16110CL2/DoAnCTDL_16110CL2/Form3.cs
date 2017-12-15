using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCTDL_16110CL2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOKSort_Click(object sender, EventArgs e)
        {
          
        }

        private void CBoxSortTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBoxTTSort.Items.Clear();
            if (CBoxSortTheo.SelectedItem == "Mã SV" || CBoxSortTheo.SelectedItem == "Lop")
            {
                CBoxTTSort.Items.Add("123");
                CBoxTTSort.Items.Add("321");
            }
            else if (CBoxSortTheo.SelectedItem == "Tên SV" || CBoxSortTheo.SelectedItem == "Khoa")
            {
                CBoxTTSort.Items.Add("a->z");
                CBoxTTSort.Items.Add("z->a");
            }
            else if (CBoxSortTheo.SelectedItem == "Điểm môn 1" || CBoxSortTheo.SelectedItem == "Điểm môn 2" || CBoxSortTheo.SelectedItem == "Điểm môn 3" || CBoxTTSort.SelectedItem == "Điểm TB" )
            {
                CBoxTTSort.Items.Add("max->min");
                CBoxTTSort.Items.Add("min->max");
            }
            else
            {
                CBoxTTSort.Items.Add("Nam");
                CBoxTTSort.Items.Add("Nữ");
            }
        }
    }
}
