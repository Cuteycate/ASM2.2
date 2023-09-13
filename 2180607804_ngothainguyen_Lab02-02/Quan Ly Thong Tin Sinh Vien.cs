using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180607804_ngothainguyen_Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cmbNganh.SelectedIndex = 0;
        }
      private int GetSelectedRow(string studentID)
        {
            for(int i =1;i<dgvStudent.Rows.Count;i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value?.ToString() == studentID) // ? dung de check xem value co duoc tra lai Null hay khong. Neu Null thi return luon ve syntax null
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtDiemTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbNganh.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMSSV.Text == "" || txtHoTen.Text == "" || txtDiemTB.Text == "")
                {
                    throw new Exception("Vui Lòng nhập đầy đủ thông tin sinh viên!");
                }
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if(selectedRow== -1)
                {
                    throw new Exception("Không tìm thấy mssv cần xóa !");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa Sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvStudent.CurrentRow.Selected = true;
                txtMSSV.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvMssv"].Value.ToString();
                txtHoTen.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvHoten"].Value.ToString();
                optFemale.Checked = "Nữ".Equals(dgvStudent.Rows[e.RowIndex].Cells["dgvGioitinh"].Value);
                optMale.Checked = "Nam".Equals(dgvStudent.Rows[e.RowIndex].Cells["dgvGioitinh"].Value);
                txtDiemTB.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvDtb"].Value.ToString();
                cmbNganh.Text = dgvStudent.Rows[e.RowIndex].Cells["dgvKhoa"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCountnam_TextChanged(object sender, EventArgs e)
        {
            {
                int countnam = 0;
                int countnu = 0;
                try
                {
                        countnam = dgvStudent.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["dgvGioiTinh"].Value?.ToString()).Count(s => s == "Nam");
                        txtCountnam.Text = countnam.ToString();
                        countnu = dgvStudent.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["dgvGioiTinh"].Value?.ToString()).Count(s => s == "Nữ");
                        txtCountnu.Text = countnu.ToString();
                    MessageBox.Show("Da hoan thanh");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }

}
