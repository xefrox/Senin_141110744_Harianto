namespace Latihan_POS
{
    partial class Customer
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exitCustClose = new System.Windows.Forms.Button();
            this.CancelCustReset = new System.Windows.Forms.Button();
            this.OkCustSave = new System.Windows.Forms.Button();
            this.txtKodePosCust = new System.Windows.Forms.TextBox();
            this.txtTeleponCust = new System.Windows.Forms.TextBox();
            this.txtEmailCust = new System.Windows.Forms.TextBox();
            this.txtAlamatCust = new System.Windows.Forms.TextBox();
            this.txtNamaCust = new System.Windows.Forms.TextBox();
            this.txtIDCust = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExitCustEdit = new System.Windows.Forms.Button();
            this.ResetCustEdit = new System.Windows.Forms.Button();
            this.OkCustEdit = new System.Windows.Forms.Button();
            this.txtKodePosEditCust = new System.Windows.Forms.TextBox();
            this.txtTeleponEditCust = new System.Windows.Forms.TextBox();
            this.txtEmailEditCust = new System.Windows.Forms.TextBox();
            this.txtAlamatEditCust = new System.Windows.Forms.TextBox();
            this.txtNamaEditCust = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDEditCust = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ExitCustDelete = new System.Windows.Forms.Button();
            this.ResetCustDelete = new System.Windows.Forms.Button();
            this.OkCustDelete = new System.Windows.Forms.Button();
            this.txtIDDeleteCust = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgridviewcust = new System.Windows.Forms.DataGridView();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridviewcust)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1054, 406);
            this.tabControl2.TabIndex = 31;
            this.tabControl2.Tag = "";
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exitCustClose);
            this.tabPage1.Controls.Add(this.CancelCustReset);
            this.tabPage1.Controls.Add(this.OkCustSave);
            this.tabPage1.Controls.Add(this.txtKodePosCust);
            this.tabPage1.Controls.Add(this.txtTeleponCust);
            this.tabPage1.Controls.Add(this.txtEmailCust);
            this.tabPage1.Controls.Add(this.txtAlamatCust);
            this.tabPage1.Controls.Add(this.txtNamaCust);
            this.tabPage1.Controls.Add(this.txtIDCust);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exitCustClose
            // 
            this.exitCustClose.Location = new System.Drawing.Point(298, 239);
            this.exitCustClose.Name = "exitCustClose";
            this.exitCustClose.Size = new System.Drawing.Size(75, 23);
            this.exitCustClose.TabIndex = 44;
            this.exitCustClose.Text = "Keluar";
            this.exitCustClose.UseVisualStyleBackColor = true;
            this.exitCustClose.Click += new System.EventHandler(this.exitCustClose_Click);
            // 
            // CancelCustReset
            // 
            this.CancelCustReset.Location = new System.Drawing.Point(217, 239);
            this.CancelCustReset.Name = "CancelCustReset";
            this.CancelCustReset.Size = new System.Drawing.Size(75, 23);
            this.CancelCustReset.TabIndex = 43;
            this.CancelCustReset.Text = "Batal";
            this.CancelCustReset.UseVisualStyleBackColor = true;
            this.CancelCustReset.Click += new System.EventHandler(this.CancelCustReset_Click);
            // 
            // OkCustSave
            // 
            this.OkCustSave.Location = new System.Drawing.Point(136, 239);
            this.OkCustSave.Name = "OkCustSave";
            this.OkCustSave.Size = new System.Drawing.Size(75, 23);
            this.OkCustSave.TabIndex = 42;
            this.OkCustSave.Text = "Ok";
            this.OkCustSave.UseVisualStyleBackColor = true;
            this.OkCustSave.Click += new System.EventHandler(this.OkCustSave_Click);
            // 
            // txtKodePosCust
            // 
            this.txtKodePosCust.Location = new System.Drawing.Point(108, 213);
            this.txtKodePosCust.Name = "txtKodePosCust";
            this.txtKodePosCust.Size = new System.Drawing.Size(262, 20);
            this.txtKodePosCust.TabIndex = 41;
            // 
            // txtTeleponCust
            // 
            this.txtTeleponCust.Location = new System.Drawing.Point(108, 187);
            this.txtTeleponCust.Name = "txtTeleponCust";
            this.txtTeleponCust.Size = new System.Drawing.Size(262, 20);
            this.txtTeleponCust.TabIndex = 41;
            // 
            // txtEmailCust
            // 
            this.txtEmailCust.Location = new System.Drawing.Point(108, 161);
            this.txtEmailCust.Name = "txtEmailCust";
            this.txtEmailCust.Size = new System.Drawing.Size(262, 20);
            this.txtEmailCust.TabIndex = 40;
            // 
            // txtAlamatCust
            // 
            this.txtAlamatCust.Location = new System.Drawing.Point(108, 135);
            this.txtAlamatCust.Name = "txtAlamatCust";
            this.txtAlamatCust.Size = new System.Drawing.Size(262, 20);
            this.txtAlamatCust.TabIndex = 39;
            // 
            // txtNamaCust
            // 
            this.txtNamaCust.Location = new System.Drawing.Point(108, 109);
            this.txtNamaCust.Name = "txtNamaCust";
            this.txtNamaCust.Size = new System.Drawing.Size(262, 20);
            this.txtNamaCust.TabIndex = 38;
            // 
            // txtIDCust
            // 
            this.txtIDCust.Enabled = false;
            this.txtIDCust.Location = new System.Drawing.Point(108, 83);
            this.txtIDCust.Name = "txtIDCust";
            this.txtIDCust.Size = new System.Drawing.Size(262, 20);
            this.txtIDCust.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Kode Pos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExitCustEdit);
            this.tabPage2.Controls.Add(this.ResetCustEdit);
            this.tabPage2.Controls.Add(this.OkCustEdit);
            this.tabPage2.Controls.Add(this.txtKodePosEditCust);
            this.tabPage2.Controls.Add(this.txtTeleponEditCust);
            this.tabPage2.Controls.Add(this.txtEmailEditCust);
            this.tabPage2.Controls.Add(this.txtAlamatEditCust);
            this.tabPage2.Controls.Add(this.txtNamaEditCust);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtIDEditCust);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExitCustEdit
            // 
            this.ExitCustEdit.Location = new System.Drawing.Point(603, 238);
            this.ExitCustEdit.Name = "ExitCustEdit";
            this.ExitCustEdit.Size = new System.Drawing.Size(75, 23);
            this.ExitCustEdit.TabIndex = 59;
            this.ExitCustEdit.Text = "Keluar";
            this.ExitCustEdit.UseVisualStyleBackColor = true;
            this.ExitCustEdit.Click += new System.EventHandler(this.ExitCustEdit_Click);
            // 
            // ResetCustEdit
            // 
            this.ResetCustEdit.Location = new System.Drawing.Point(522, 238);
            this.ResetCustEdit.Name = "ResetCustEdit";
            this.ResetCustEdit.Size = new System.Drawing.Size(75, 23);
            this.ResetCustEdit.TabIndex = 58;
            this.ResetCustEdit.Text = "Batal";
            this.ResetCustEdit.UseVisualStyleBackColor = true;
            this.ResetCustEdit.Click += new System.EventHandler(this.ResetCustEdit_Click);
            // 
            // OkCustEdit
            // 
            this.OkCustEdit.Location = new System.Drawing.Point(441, 238);
            this.OkCustEdit.Name = "OkCustEdit";
            this.OkCustEdit.Size = new System.Drawing.Size(75, 23);
            this.OkCustEdit.TabIndex = 57;
            this.OkCustEdit.Text = "Ok";
            this.OkCustEdit.UseVisualStyleBackColor = true;
            this.OkCustEdit.Click += new System.EventHandler(this.OkCustEdit_Click);
            // 
            // txtKodePosEditCust
            // 
            this.txtKodePosEditCust.Location = new System.Drawing.Point(416, 207);
            this.txtKodePosEditCust.Name = "txtKodePosEditCust";
            this.txtKodePosEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtKodePosEditCust.TabIndex = 56;
            // 
            // txtTeleponEditCust
            // 
            this.txtTeleponEditCust.Location = new System.Drawing.Point(416, 181);
            this.txtTeleponEditCust.Name = "txtTeleponEditCust";
            this.txtTeleponEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtTeleponEditCust.TabIndex = 56;
            // 
            // txtEmailEditCust
            // 
            this.txtEmailEditCust.Location = new System.Drawing.Point(416, 155);
            this.txtEmailEditCust.Name = "txtEmailEditCust";
            this.txtEmailEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtEmailEditCust.TabIndex = 55;
            // 
            // txtAlamatEditCust
            // 
            this.txtAlamatEditCust.Location = new System.Drawing.Point(416, 129);
            this.txtAlamatEditCust.Name = "txtAlamatEditCust";
            this.txtAlamatEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtAlamatEditCust.TabIndex = 54;
            // 
            // txtNamaEditCust
            // 
            this.txtNamaEditCust.Location = new System.Drawing.Point(416, 103);
            this.txtNamaEditCust.Name = "txtNamaEditCust";
            this.txtNamaEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtNamaEditCust.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Kode Pos";
            // 
            // txtIDEditCust
            // 
            this.txtIDEditCust.Location = new System.Drawing.Point(416, 77);
            this.txtIDEditCust.Name = "txtIDEditCust";
            this.txtIDEditCust.Size = new System.Drawing.Size(262, 20);
            this.txtIDEditCust.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Telepon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Alamat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Nama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ExitCustDelete);
            this.tabPage3.Controls.Add(this.ResetCustDelete);
            this.tabPage3.Controls.Add(this.OkCustDelete);
            this.tabPage3.Controls.Add(this.txtIDDeleteCust);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1046, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExitCustDelete
            // 
            this.ExitCustDelete.Location = new System.Drawing.Point(555, 256);
            this.ExitCustDelete.Name = "ExitCustDelete";
            this.ExitCustDelete.Size = new System.Drawing.Size(75, 23);
            this.ExitCustDelete.TabIndex = 62;
            this.ExitCustDelete.Text = "Keluar";
            this.ExitCustDelete.UseVisualStyleBackColor = true;
            this.ExitCustDelete.Click += new System.EventHandler(this.ExitCustDelete_Click);
            // 
            // ResetCustDelete
            // 
            this.ResetCustDelete.Location = new System.Drawing.Point(474, 256);
            this.ResetCustDelete.Name = "ResetCustDelete";
            this.ResetCustDelete.Size = new System.Drawing.Size(75, 23);
            this.ResetCustDelete.TabIndex = 61;
            this.ResetCustDelete.Text = "Batal";
            this.ResetCustDelete.UseVisualStyleBackColor = true;
            this.ResetCustDelete.Click += new System.EventHandler(this.ResetCustDelete_Click);
            // 
            // OkCustDelete
            // 
            this.OkCustDelete.Location = new System.Drawing.Point(393, 256);
            this.OkCustDelete.Name = "OkCustDelete";
            this.OkCustDelete.Size = new System.Drawing.Size(75, 23);
            this.OkCustDelete.TabIndex = 60;
            this.OkCustDelete.Text = "Ok";
            this.OkCustDelete.UseVisualStyleBackColor = true;
            this.OkCustDelete.Click += new System.EventHandler(this.OkCustDelete_Click);
            // 
            // txtIDDeleteCust
            // 
            this.txtIDDeleteCust.Location = new System.Drawing.Point(417, 150);
            this.txtIDDeleteCust.Name = "txtIDDeleteCust";
            this.txtIDDeleteCust.Size = new System.Drawing.Size(262, 20);
            this.txtIDDeleteCust.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgridviewcust);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1046, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "GridView";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgridviewcust
            // 
            this.dgridviewcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridviewcust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridviewcust.Location = new System.Drawing.Point(3, 3);
            this.dgridviewcust.Name = "dgridviewcust";
            this.dgridviewcust.Size = new System.Drawing.Size(1040, 374);
            this.dgridviewcust.TabIndex = 0;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 430);
            this.Controls.Add(this.tabControl2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridviewcust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button exitCustClose;
        private System.Windows.Forms.Button CancelCustReset;
        private System.Windows.Forms.Button OkCustSave;
        private System.Windows.Forms.TextBox txtTeleponCust;
        private System.Windows.Forms.TextBox txtEmailCust;
        private System.Windows.Forms.TextBox txtAlamatCust;
        private System.Windows.Forms.TextBox txtNamaCust;
        private System.Windows.Forms.TextBox txtIDCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ExitCustEdit;
        private System.Windows.Forms.Button ResetCustEdit;
        private System.Windows.Forms.Button OkCustEdit;
        private System.Windows.Forms.TextBox txtTeleponEditCust;
        private System.Windows.Forms.TextBox txtEmailEditCust;
        private System.Windows.Forms.TextBox txtAlamatEditCust;
        private System.Windows.Forms.TextBox txtNamaEditCust;
        private System.Windows.Forms.TextBox txtIDEditCust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ExitCustDelete;
        private System.Windows.Forms.Button ResetCustDelete;
        private System.Windows.Forms.Button OkCustDelete;
        private System.Windows.Forms.TextBox txtIDDeleteCust;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgridviewcust;
        private System.Windows.Forms.TextBox txtKodePosCust;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKodePosEditCust;
        private System.Windows.Forms.Label label15;

    }
}