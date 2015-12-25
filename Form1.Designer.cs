namespace callXBFLibrary
{
    partial class frmCall_XBF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCall_XBF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadXBF = new System.Windows.Forms.Button();
            this.edtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWriteXBF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadXBF);
            this.groupBox1.Controls.Add(this.edtFileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(40, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读取XBF文件（当前目录下）";
            // 
            // btnReadXBF
            // 
            this.btnReadXBF.Location = new System.Drawing.Point(33, 156);
            this.btnReadXBF.Name = "btnReadXBF";
            this.btnReadXBF.Size = new System.Drawing.Size(75, 23);
            this.btnReadXBF.TabIndex = 2;
            this.btnReadXBF.Text = "&Ok";
            this.btnReadXBF.UseVisualStyleBackColor = true;
            this.btnReadXBF.Click += new System.EventHandler(this.btnReadXBF_Click);
            // 
            // edtFileName
            // 
            this.edtFileName.Location = new System.Drawing.Point(57, 61);
            this.edtFileName.Name = "edtFileName";
            this.edtFileName.Size = new System.Drawing.Size(201, 21);
            this.edtFileName.TabIndex = 1;
            this.edtFileName.Text = "example.xbf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "xbf文件名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWriteXBF);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(352, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "写入数据到XBF文件";
            // 
            // btnWriteXBF
            // 
            this.btnWriteXBF.Location = new System.Drawing.Point(162, 156);
            this.btnWriteXBF.Name = "btnWriteXBF";
            this.btnWriteXBF.Size = new System.Drawing.Size(75, 23);
            this.btnWriteXBF.TabIndex = 3;
            this.btnWriteXBF.Text = "O&k";
            this.btnWriteXBF.UseVisualStyleBackColor = true;
            this.btnWriteXBF.Click += new System.EventHandler(this.btnWriteXBF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "在写入前，请修改INI文件的各项数值。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注意：XBF文件数据存放在INI文件中！";
            // 
            // frmCall_XBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCall_XBF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用XBF库";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadXBF;
        private System.Windows.Forms.Button btnWriteXBF;
    }
}

