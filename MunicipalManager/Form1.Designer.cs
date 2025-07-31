namespace MunicipalManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOfficials;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvOfficials = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficials)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvOfficials
            // 
            this.dgvOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficials.Location = new System.Drawing.Point(20, 20);
            this.dgvOfficials.Name = "dgvOfficials";
            this.dgvOfficials.Size = new System.Drawing.Size(600, 200);
            this.dgvOfficials.TabIndex = 0;
            this.dgvOfficials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfficials_CellClick);

            // 
            // Labels
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 240);
            this.lblName.Name = "lblName";
            this.lblName.Text = "ชื่อ:";

            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(20, 270);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Text = "ตำแหน่ง:";

            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(20, 300);
            this.lblDept.Name = "lblDept";
            this.lblDept.Text = "แผนก:";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 330);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "อีเมล:";

            // 
            // TextBoxes
            // 
            this.txtName.Location = new System.Drawing.Point(100, 237);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);

            this.txtPosition.Location = new System.Drawing.Point(100, 267);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(200, 20);

            this.txtDept.Location = new System.Drawing.Point(100, 297);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(200, 20);

            this.txtEmail.Location = new System.Drawing.Point(100, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            // 
            // Buttons
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(350, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.Text = "แก้ไข";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(350, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.dgvOfficials);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "ระบบจัดการเจ้าหน้าที่เทศบาล";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
