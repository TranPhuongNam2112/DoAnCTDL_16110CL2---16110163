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
    public partial class Form1 : Form
    {
        string flag;
        DataTable dtSV;
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LockControl();

            dtSV = CreateTable();
        }

        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            

            txtTenSV.ReadOnly = true;
            txtMaSV.ReadOnly = true;
            txtKhoa.ReadOnly = true;
            txtDiem1.ReadOnly = true;
            txtDiem2.ReadOnly = true;
            txtLop.ReadOnly = true;
            txtGioi.ReadOnly = true;
            txtDiem4.ReadOnly = true;

            btnThem.Focus();
        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            


            txtMaSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            txtGioi.ReadOnly = false;
            txtKhoa.ReadOnly = false;
            txtLop.ReadOnly = false;
            txtDiem1.ReadOnly = false;
            txtDiem2.ReadOnly = false;
            txtDiem3.ReadOnly = false;
            txtDiem4.ReadOnly = false;

            txtMaSV.Focus();
        }

        public DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Gioi");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("Lop");
            dt.Columns.Add("Diem1");
            dt.Columns.Add("Diem2");
            dt.Columns.Add("Diem3");
            dt.Columns.Add("Diem4");
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";

            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtGioi.Text = "";
            txtKhoa.Text = "";
            txtLop.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
            txtDiem3.Text = "";
            txtDiem4.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    dtSV.Rows.Add(txtMaSV.Text, txtTenSV.Text, txtGioi.Text, txtKhoa.Text, txtLop.Text, txtDiem1.Text, txtDiem2.Text, txtDiem3.Text, txtDiem4.Text);
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                }

            }
            else if (flag == "edit")
            {
                dtSV.Rows[index][0] = txtMaSV.Text;
                dtSV.Rows[index][1] = txtTenSV.Text;
                dtSV.Rows[index][2] = txtGioi.Text;
                dtSV.Rows[index][3] = txtKhoa.Text;
                dtSV.Rows[index][4] = txtLop.Text;
                dtSV.Rows[index][5] = txtDiem1.Text;
                dtSV.Rows[index][6] = txtDiem2.Text;
                dtSV.Rows[index][7] = txtDiem3.Text;
                dtSV.Rows[index][8] = txtDiem4.Text;
                dataGridSinhVien.DataSource = dtSV;
                dataGridSinhVien.RefreshEdit();
            }
            LockControl();
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGioi.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoa.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem1.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm môn 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem2.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm môn 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem2.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem3.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm môn 3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem3.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem4.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm môn 4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem4.Focus();
                return false;
            }
            return true;
        }

        private void dataGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridSinhVien.CurrentCell.RowIndex == null ? -1 : dataGridSinhVien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridSinhVien.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                txtMaSV.Text = dataGridSinhVien.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dataGridSinhVien.Rows[index].Cells[1].Value.ToString();
                txtGioi.Text = dataGridSinhVien.Rows[index].Cells[2].Value.ToString();
                txtKhoa.Text = dataGridSinhVien.Rows[index].Cells[3].Value.ToString();
                txtLop.Text = dataGridSinhVien.Rows[index].Cells[4].Value.ToString();
                txtDiem1.Text = dataGridSinhVien.Rows[index].Cells[5].Value.ToString();
                txtDiem2.Text = dataGridSinhVien.Rows[index].Cells[6].Value.ToString();
                txtDiem3.Text = dataGridSinhVien.Rows[index].Cells[7].Value.ToString();
                txtDiem4.Text = dataGridSinhVien.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridSinhVien.DataSource = dtSV;
                dataGridSinhVien.RefreshEdit();
            }
        }
       

        private void CBoxSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxSTK.SelectedItem != "Không")
            {
                string rowFilter = string.Format("[{0}] = '{1}'", dtSV.Columns[3], CBoxSTK.SelectedItem);
                (dataGridSinhVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void CBoxSTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxSTL.SelectedItem != "Không")
            {
                string rowFilter = string.Format("[{0}] = '{1}'", dtSV.Columns[4], CBoxSTL.SelectedItem);
                (dataGridSinhVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void CBoxSTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxSTG.SelectedItem != "Không")
            {
                string rowFilter = string.Format("[{0}] = '{1}'", dtSV.Columns[2], CBoxSTG.SelectedItem);
                (dataGridSinhVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LockControl();
            string rowFilter = string.Format("[{0}] = '{1}'", dtSV.Columns[0], txttimmaSV.Text);
            (dataGridSinhVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridSinhVien.RefreshEdit();
        }
    }
}
