using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class frmChamDiem : Form
    {
        public frmChamDiem(string malh)
        {
            this.malh = malh;
            InitializeComponent();
        }
        private string malh;
        private void frmChamDiem_Load(object sender, EventArgs e)
        {
            LoadDSD();
        }

        private void LoadDSD()
        {
            List<CustomParameter> firstPara = new List<CustomParameter>();

            firstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malh
            });
            dgvChamDiem.DataSource = new Database().SelectData("SelectDiem", firstPara);
            // đặt tên cột


        }

        private void dgvChamDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvChamDiem.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                
                //Cần truyền mã sinh viên này vào form sinh viên
                new frmUpdateDiem(msv,malh).ShowDialog();
                //MessageBox.Show("Mã sinh viên:" + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());

                //Sau khi form frmSinhVien đc đóng lại
                //Cần load lại danh sách sinh viên
                LoadDSD();
            }
        }
    }
}
