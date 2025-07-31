using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalManager
{
    public partial class Form1 : Form
    {
        // ฐานข้อมูลจำลอง
        private List<Official> officials = new List<Official>();

        // ID ของแถวที่ถูกเลือก
        private int selectedId = -1;

        public Form1()
        {
            InitializeComponent();
            LoadDummyData();
            RefreshGrid();
        }

        // เพิ่มข้อมูลจำลองเริ่มต้น
        private void LoadDummyData()
        {
            officials.Clear(); // เคลียร์ข้อมูลเดิมก่อน

            string[] names = {
        "นายสมชาย ใจดี", "นางสาวสมฤดี ใจงาม", "นายประเสริฐ มีสุข", "นางจิราภรณ์ แก้วใส",
        "นายวีระพงษ์ ทองคำ", "นางสาวมัณฑนา ศรีบุญ", "นายอดิศักดิ์ กำแหง", "นางพรพิมล ศักดิ์ศรี",
        "นายสกล สุขใจ", "นางสาวสุภาวดี อินทร", "นายยุทธนา สายใจ", "นางสาววรรณา สมบูรณ์",
        "นายเอกชัย คำดี", "นางสาวณัฐกานต์ ประเสริฐสุข", "นายศราวุธ เพียรดี", "นางสาวทิพวรรณ สุขแสน",
        "นายประยุทธ ชาญกิจ", "นางสาวมยุรี เที่ยงตรง", "นายเกรียงไกร เสถียร", "นางสาวธัญญา คำสว่าง"
    };

            string[] positions = {
        "ปลัดเทศบาล", "เจ้าหน้าที่การเงิน", "เจ้าหน้าที่ทะเบียน", "เจ้าหน้าที่โยธา",
        "เจ้าหน้าที่สาธารณสุข", "เจ้าหน้าที่วิเคราะห์", "เจ้าหน้าที่จัดเก็บรายได้"
    };

            string[] departments = {
        "กองคลัง", "กองช่าง", "กองสาธารณสุข", "สำนักงานปลัด", "กองยุทธศาสตร์", "กองการศึกษา"
    };

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                var name = names[i % names.Length];
                var position = positions[rnd.Next(positions.Length)];
                var department = departments[rnd.Next(departments.Length)];
                var email = $"official{i + 1}@example.com";

                officials.Add(new Official
                {
                    Id = i + 1,
                    FullName = name,
                    Position = position,
                    Department = department,
                    Email = email
                });
            }
        }


        // โหลดข้อมูลลง DataGridView
        private void RefreshGrid()
        {
            dgvOfficials.DataSource = null;
            dgvOfficials.DataSource = officials.Select(o => new
            {
                o.Id,
                ชื่อ = o.FullName,
                ตำแหน่ง = o.Position,
                แผนก = o.Department,
                อีเมล = o.Email
            }).ToList();

            // ซ่อนคอลัมน์ Id
            dgvOfficials.Columns["Id"].Visible = false;
        }

        // ปุ่มเพิ่มข้อมูล
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            var newOfficial = new Official
            {
                Id = officials.Count > 0 ? officials.Max(o => o.Id) + 1 : 1,
                FullName = txtName.Text,
                Position = txtPosition.Text,
                Department = txtDept.Text,
                Email = txtEmail.Text
            };

            officials.Add(newOfficial);
            RefreshGrid();
            ClearForm();
        }

        // เมื่อคลิกเลือกแถวใน DataGridView
        private void dgvOfficials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = (int)dgvOfficials.Rows[e.RowIndex].Cells["Id"].Value;
                var official = officials.FirstOrDefault(o => o.Id == selectedId);

                if (official != null)
                {
                    txtName.Text = official.FullName;
                    txtPosition.Text = official.Position;
                    txtDept.Text = official.Department;
                    txtEmail.Text = official.Email;
                }
            }
        }

        // ปุ่มแก้ไขข้อมูล
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var official = officials.FirstOrDefault(o => o.Id == selectedId);
            if (official != null)
            {
                official.FullName = txtName.Text;
                official.Position = txtPosition.Text;
                official.Department = txtDept.Text;
                official.Email = txtEmail.Text;

                RefreshGrid();
                ClearForm();
            }
        }

        // ปุ่มลบข้อมูล
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var official = officials.FirstOrDefault(o => o.Id == selectedId);
            if (official != null)
            {
                var confirm = MessageBox.Show("ยืนยันการลบข้อมูล?", "ยืนยัน", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    officials.Remove(official);
                    RefreshGrid();
                    ClearForm();
                }
            }
        }

        // ล้างฟอร์มหลังการเพิ่ม/แก้ไข/ลบ
        private void ClearForm()
        {
            txtName.Clear();
            txtPosition.Clear();
            txtDept.Clear();
            txtEmail.Clear();
            selectedId = -1;
        }
    }
}
