namespace CSharp_BANGCT
{
    partial class BangCT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtstartNum = new TextBox();
            txtendNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txttotalNum = new TextBox();
            txtpowerNum = new TextBox();
            txttotalChan = new TextBox();
            txttotalLe = new TextBox();
            btlthanhtoan = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtstartNum
            // 
            txtstartNum.Location = new Point(305, 75);
            txtstartNum.Name = "txtstartNum";
            txtstartNum.Size = new Size(100, 23);
            txtstartNum.TabIndex = 0;
            // 
            // txtendNum
            // 
            txtendNum.Location = new Point(501, 76);
            txtendNum.Name = "txtendNum";
            txtendNum.Size = new Size(100, 23);
            txtendNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 75);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 2;
            label1.Text = "GIỚI HẠNG CỦA DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(217, 82);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 3;
            label2.Text = "SỐ BẮT ĐẦU";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 81);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "SỐ KÉT THÚC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "KẾT QUẢ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 6;
            label5.Text = "TỔNG CÁC SỐ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 7;
            label6.Text = "TÍCH CÁC SỐ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 8;
            label7.Text = "TỔNG CÁC SỐ CHẴN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 244);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 9;
            label8.Text = "TỔNG CÁC SỐ LẺ";
            // 
            // txttotalNum
            // 
            txttotalNum.Enabled = false;
            txttotalNum.Location = new Point(200, 138);
            txttotalNum.Name = "txttotalNum";
            txttotalNum.Size = new Size(205, 23);
            txttotalNum.TabIndex = 10;
            txttotalNum.TextChanged += txttotalNum_TextChanged;
            // 
            // txtpowerNum
            // 
            txtpowerNum.Enabled = false;
            txtpowerNum.Location = new Point(200, 171);
            txtpowerNum.Name = "txtpowerNum";
            txtpowerNum.Size = new Size(205, 23);
            txtpowerNum.TabIndex = 11;
            // 
            // txttotalChan
            // 
            txttotalChan.Enabled = false;
            txttotalChan.Location = new Point(200, 204);
            txttotalChan.Name = "txttotalChan";
            txttotalChan.Size = new Size(205, 23);
            txttotalChan.TabIndex = 12;
            // 
            // txttotalLe
            // 
            txttotalLe.Enabled = false;
            txttotalLe.Location = new Point(200, 236);
            txttotalLe.Name = "txttotalLe";
            txttotalLe.Size = new Size(205, 23);
            txttotalLe.TabIndex = 13;
            // 
            // btlthanhtoan
            // 
            btlthanhtoan.Location = new Point(247, 288);
            btlthanhtoan.Name = "btlthanhtoan";
            btlthanhtoan.Size = new Size(102, 23);
            btlthanhtoan.TabIndex = 14;
            btlthanhtoan.Text = "TINH TOAN";
            btlthanhtoan.UseVisualStyleBackColor = true;
            btlthanhtoan.Click += btlthanhtoan_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BangCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btlthanhtoan);
            Controls.Add(txttotalLe);
            Controls.Add(txttotalChan);
            Controls.Add(txtpowerNum);
            Controls.Add(txttotalNum);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtendNum);
            Controls.Add(txtstartNum);
            Name = "BangCT";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtstartNum;
        private TextBox txtendNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txttotalNum;
        private TextBox txtpowerNum;
        private TextBox txttotalChan;
        private TextBox txttotalLe;
        private Button btlthanhtoan;
        private ErrorProvider errorProvider1;
    }
}
