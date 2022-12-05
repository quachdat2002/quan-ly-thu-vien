
namespace QuanLyThuVien_Winform
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.dtgMuonSach = new System.Windows.Forms.DataGridView();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 286);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.Khaki;
            this.btnMuon.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnMuon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnMuon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.ForeColor = System.Drawing.Color.Black;
            this.btnMuon.Location = new System.Drawing.Point(17, 142);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(217, 54);
            this.btnMuon.TabIndex = 24;
            this.btnMuon.Text = "Quản lý mượn sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.Tomato;
            this.btnDocGia.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnDocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.Location = new System.Drawing.Point(17, 80);
            this.btnDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(217, 54);
            this.btnDocGia.TabIndex = 23;
            this.btnDocGia.Text = "Quản lý độc giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // dtgMuonSach
            // 
            this.dtgMuonSach.AllowUserToAddRows = false;
            this.dtgMuonSach.AllowUserToDeleteRows = false;
            this.dtgMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMuonSach.BackgroundColor = System.Drawing.Color.Khaki;
            this.dtgMuonSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenSach,
            this.TacGia,
            this.NhaXuatBan,
            this.NamXuatBan,
            this.DonGia,
            this.SoLuong});
            this.dtgMuonSach.Enabled = false;
            this.dtgMuonSach.Location = new System.Drawing.Point(259, 16);
            this.dtgMuonSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgMuonSach.Name = "dtgMuonSach";
            this.dtgMuonSach.ReadOnly = true;
            this.dtgMuonSach.RowHeadersWidth = 51;
            this.dtgMuonSach.Size = new System.Drawing.Size(1062, 635);
            this.dtgMuonSach.TabIndex = 22;
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.DimGray;
            this.btnTra.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.ForeColor = System.Drawing.Color.White;
            this.btnTra.Location = new System.Drawing.Point(17, 206);
            this.btnTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(217, 54);
            this.btnTra.TabIndex = 21;
            this.btnTra.Text = "Quản lý trả sách";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.Location = new System.Drawing.Point(17, 16);
            this.btnSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(217, 54);
            this.btnSach.TabIndex = 20;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã sách";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 8;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "NXB";
            this.NhaXuatBan.MinimumWidth = 8;
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm XB";
            this.NamXuatBan.MinimumWidth = 8;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1348, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.dtgMuonSach);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnSach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Main";
            this.Text = "Quản lý thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.DataGridView dtgMuonSach;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}