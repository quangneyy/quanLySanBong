﻿
namespace QuanLySanBong
{
    partial class fBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanHang));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.dgvDanhSachMatHang = new System.Windows.Forms.DataGridView();
            this.lblSanDangChon = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.dgvChiTietBanHang = new System.Windows.Forms.DataGridView();
            this.pnlThoiGian = new System.Windows.Forms.Panel();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.mtbKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbBatDau = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChiTietSan = new System.Windows.Forms.Label();
            this.tbcBanHang = new System.Windows.Forms.TabControl();
            this.tpBanHang = new System.Windows.Forms.TabPage();
            this.tpLSGD = new System.Windows.Forms.TabPage();
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.dgvLSGD = new System.Windows.Forms.DataGridView();
            this.pdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pddHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanHang)).BeginInit();
            this.pnlThoiGian.SuspendLayout();
            this.tbcBanHang.SuspendLayout();
            this.tpBanHang.SuspendLayout();
            this.tpLSGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGD)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.dgvDanhSachMatHang);
            this.pnlControl.Controls.Add(this.lblSanDangChon);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(594, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(434, 606);
            this.pnlControl.TabIndex = 1;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControl_Paint);
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.AllowUserToAddRows = false;
            this.dgvDanhSachMatHang.AllowUserToDeleteRows = false;
            this.dgvDanhSachMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachMatHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMatHang.Location = new System.Drawing.Point(3, 65);
            this.dgvDanhSachMatHang.MultiSelect = false;
            this.dgvDanhSachMatHang.Name = "dgvDanhSachMatHang";
            this.dgvDanhSachMatHang.ReadOnly = true;
            this.dgvDanhSachMatHang.RowHeadersWidth = 62;
            this.dgvDanhSachMatHang.RowTemplate.Height = 28;
            this.dgvDanhSachMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMatHang.Size = new System.Drawing.Size(428, 541);
            this.dgvDanhSachMatHang.TabIndex = 4;
            this.dgvDanhSachMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMatHang_CellContentClick);
            this.dgvDanhSachMatHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMatHang_CellDoubleClick);
            // 
            // lblSanDangChon
            // 
            this.lblSanDangChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSanDangChon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanDangChon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSanDangChon.Location = new System.Drawing.Point(15, 9);
            this.lblSanDangChon.Name = "lblSanDangChon";
            this.lblSanDangChon.Size = new System.Drawing.Size(407, 53);
            this.lblSanDangChon.TabIndex = 0;
            this.lblSanDangChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.dgvChiTietBanHang);
            this.panelOrder.Controls.Add(this.pnlThoiGian);
            this.panelOrder.Controls.Add(this.lblChiTietSan);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrder.Location = new System.Drawing.Point(0, 441);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(594, 165);
            this.panelOrder.TabIndex = 2;
            // 
            // dgvChiTietBanHang
            // 
            this.dgvChiTietBanHang.AllowUserToAddRows = false;
            this.dgvChiTietBanHang.AllowUserToDeleteRows = false;
            this.dgvChiTietBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietBanHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBanHang.Location = new System.Drawing.Point(230, 34);
            this.dgvChiTietBanHang.MultiSelect = false;
            this.dgvChiTietBanHang.Name = "dgvChiTietBanHang";
            this.dgvChiTietBanHang.ReadOnly = true;
            this.dgvChiTietBanHang.RowHeadersWidth = 62;
            this.dgvChiTietBanHang.RowTemplate.Height = 28;
            this.dgvChiTietBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBanHang.Size = new System.Drawing.Size(358, 111);
            this.dgvChiTietBanHang.TabIndex = 5;
            // 
            // pnlThoiGian
            // 
            this.pnlThoiGian.Controls.Add(this.btnBatDau);
            this.pnlThoiGian.Controls.Add(this.btnKetThuc);
            this.pnlThoiGian.Controls.Add(this.mtbKetThuc);
            this.pnlThoiGian.Controls.Add(this.label4);
            this.pnlThoiGian.Controls.Add(this.mtbBatDau);
            this.pnlThoiGian.Controls.Add(this.label3);
            this.pnlThoiGian.Location = new System.Drawing.Point(3, 31);
            this.pnlThoiGian.Name = "pnlThoiGian";
            this.pnlThoiGian.Size = new System.Drawing.Size(221, 120);
            this.pnlThoiGian.TabIndex = 3;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.SystemColors.Info;
            this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBatDau.Location = new System.Drawing.Point(4, 76);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(97, 38);
            this.btnBatDau.TabIndex = 9;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.Info;
            this.btnKetThuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKetThuc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKetThuc.Location = new System.Drawing.Point(110, 76);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(97, 38);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // mtbKetThuc
            // 
            this.mtbKetThuc.Location = new System.Drawing.Point(78, 44);
            this.mtbKetThuc.Mask = "00/00/0000 90:00";
            this.mtbKetThuc.Name = "mtbKetThuc";
            this.mtbKetThuc.Size = new System.Drawing.Size(140, 26);
            this.mtbKetThuc.TabIndex = 7;
            this.mtbKetThuc.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(0, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết thúc";
            // 
            // mtbBatDau
            // 
            this.mtbBatDau.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbBatDau.Location = new System.Drawing.Point(77, 12);
            this.mtbBatDau.Mask = "00/00/0000 90:00";
            this.mtbBatDau.Name = "mtbBatDau";
            this.mtbBatDau.Size = new System.Drawing.Size(140, 26);
            this.mtbBatDau.TabIndex = 5;
            this.mtbBatDau.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bắt đầu";
            // 
            // lblChiTietSan
            // 
            this.lblChiTietSan.AutoSize = true;
            this.lblChiTietSan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChiTietSan.Location = new System.Drawing.Point(33, 9);
            this.lblChiTietSan.Name = "lblChiTietSan";
            this.lblChiTietSan.Size = new System.Drawing.Size(301, 19);
            this.lblChiTietSan.TabIndex = 1;
            this.lblChiTietSan.Text = "Danh Sách Mặt Hàng Sân Đã Sử Dụng";
            // 
            // tbcBanHang
            // 
            this.tbcBanHang.Controls.Add(this.tpBanHang);
            this.tbcBanHang.Controls.Add(this.tpLSGD);
            this.tbcBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcBanHang.Location = new System.Drawing.Point(0, 0);
            this.tbcBanHang.Name = "tbcBanHang";
            this.tbcBanHang.SelectedIndex = 0;
            this.tbcBanHang.Size = new System.Drawing.Size(594, 441);
            this.tbcBanHang.TabIndex = 3;
            // 
            // tpBanHang
            // 
            this.tpBanHang.Controls.Add(this.tbcContent);
            this.tpBanHang.Location = new System.Drawing.Point(4, 29);
            this.tpBanHang.Name = "tpBanHang";
            this.tpBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanHang.Size = new System.Drawing.Size(586, 408);
            this.tpBanHang.TabIndex = 0;
            this.tpBanHang.Text = "Bán hàng";
            this.tpBanHang.UseVisualStyleBackColor = true;
            // 
            // tpLSGD
            // 
            this.tpLSGD.Controls.Add(this.dgvLSGD);
            this.tpLSGD.Location = new System.Drawing.Point(4, 29);
            this.tpLSGD.Name = "tpLSGD";
            this.tpLSGD.Padding = new System.Windows.Forms.Padding(3);
            this.tpLSGD.Size = new System.Drawing.Size(586, 408);
            this.tpLSGD.TabIndex = 1;
            this.tpLSGD.Text = "Lịch sử giao dịch";
            this.tpLSGD.UseVisualStyleBackColor = true;
            // 
            // tbcContent
            // 
            this.tbcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcContent.Location = new System.Drawing.Point(3, 3);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(580, 402);
            this.tbcContent.TabIndex = 1;
            this.tbcContent.SelectedIndexChanged += new System.EventHandler(this.tbcContent_SelectedIndexChanged);
            // 
            // dgvLSGD
            // 
            this.dgvLSGD.AllowUserToAddRows = false;
            this.dgvLSGD.AllowUserToDeleteRows = false;
            this.dgvLSGD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLSGD.Location = new System.Drawing.Point(3, 3);
            this.dgvLSGD.Name = "dgvLSGD";
            this.dgvLSGD.ReadOnly = true;
            this.dgvLSGD.RowHeadersWidth = 62;
            this.dgvLSGD.RowTemplate.Height = 28;
            this.dgvLSGD.Size = new System.Drawing.Size(580, 402);
            this.dgvLSGD.TabIndex = 0;
            this.dgvLSGD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSGD_CellDoubleClick);
            // 
            // pdHoaDon
            // 
            this.pdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdHoaDon_PrintPage);
            // 
            // pddHoaDon
            // 
            this.pddHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pddHoaDon.Enabled = true;
            this.pddHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pddHoaDon.Icon")));
            this.pddHoaDon.Name = "pddHoaDon";
            this.pddHoaDon.Visible = false;
            // 
            // fBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1028, 606);
            this.Controls.Add(this.tbcBanHang);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.pnlControl);
            this.Name = "fBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fBanHang";
            this.Load += new System.EventHandler(this.fBanHang_Load);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanHang)).EndInit();
            this.pnlThoiGian.ResumeLayout(false);
            this.pnlThoiGian.PerformLayout();
            this.tbcBanHang.ResumeLayout(false);
            this.tpBanHang.ResumeLayout(false);
            this.tpLSGD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label lblSanDangChon;
        private System.Windows.Forms.Label lblChiTietSan;
        private System.Windows.Forms.DataGridView dgvDanhSachMatHang;
        private System.Windows.Forms.Panel pnlThoiGian;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.MaskedTextBox mtbKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChiTietBanHang;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.TabControl tbcBanHang;
        private System.Windows.Forms.TabPage tpBanHang;
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.TabPage tpLSGD;
        private System.Windows.Forms.DataGridView dgvLSGD;
        private System.Drawing.Printing.PrintDocument pdHoaDon;
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
    }
}