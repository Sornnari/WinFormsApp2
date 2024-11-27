namespace WinFormsApp1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTriangleArea = new Button();
            txtHeight = new TextBox();
            txtWidth = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnPolygonArea = new Button();
            txtPolygonWidth = new TextBox();
            label4 = new Label();
            lblResult = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(47, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(316, 65);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(176, 47);
            btnCircleArea.TabIndex = 2;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(92, 65);
            txtRadius.Multiline = true;
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(149, 37);
            txtRadius.TabIndex = 2;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 75);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 2;
            label1.Text = "รัศมี";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(47, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(316, 75);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(176, 47);
            btnTriangleArea.TabIndex = 3;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(114, 52);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(149, 37);
            txtHeight.TabIndex = 3;
            txtHeight.Text = "2";
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(114, 116);
            txtWidth.Multiline = true;
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(149, 37);
            txtWidth.TabIndex = 4;
            txtWidth.Text = "3";
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 55);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 3;
            label2.Text = "ความสูง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 119);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "ความยาวฐาน";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(btnPolygonArea);
            groupBox3.Controls.Add(txtPolygonWidth);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(47, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(541, 180);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // btnPolygonArea
            // 
            btnPolygonArea.Location = new Point(316, 77);
            btnPolygonArea.Name = "btnPolygonArea";
            btnPolygonArea.Size = new Size(176, 47);
            btnPolygonArea.TabIndex = 4;
            btnPolygonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            btnPolygonArea.UseVisualStyleBackColor = true;
            btnPolygonArea.Click += btnPolygonArea_Click;
            // 
            // txtPolygonWidth
            // 
            txtPolygonWidth.Location = new Point(114, 85);
            txtPolygonWidth.Multiline = true;
            txtPolygonWidth.Name = "txtPolygonWidth";
            txtPolygonWidth.Size = new Size(149, 37);
            txtPolygonWidth.TabIndex = 5;
            txtPolygonWidth.Text = "4";
            txtPolygonWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 88);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 5;
            label4.Text = "ความยาวฐาน";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(128, 255, 255);
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(796, 80);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(214, 135);
            lblResult.TabIndex = 2;
            lblResult.Text = "label5";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(796, 56);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 3;
            label6.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 713);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Button btnTriangleArea;
        private TextBox txtHeight;
        private TextBox txtWidth;
        private Label label2;
        private Label label3;
        private Button btnPolygonArea;
        private TextBox txtPolygonWidth;
        private Label label4;
        private Label lblResult;
        private Label label6;
    }
}
