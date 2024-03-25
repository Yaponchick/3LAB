namespace _3LAB
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
            components = new System.ComponentModel.Container();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtResult = new TextBox();
            comboBox1 = new ComboBox();
            txtThird = new TextBox();
            txtFourth = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(22, 35);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(66, 27);
            txtFirst.TabIndex = 0;
            txtFirst.TextChanged += onValueChanged;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(22, 68);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(66, 27);
            txtSecond.TabIndex = 1;
            txtSecond.TextChanged += onValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtResult
            // 
            txtResult.Location = new Point(272, 49);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(111, 27);
            txtResult.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/", "<", ">" });
            comboBox1.Location = new Point(93, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(43, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "+";
/*            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
*/            comboBox1.TextChanged += onValueChanged;
            // 
            // txtThird
            // 
            txtThird.Location = new Point(152, 35);
            txtThird.Name = "txtThird";
            txtThird.Size = new Size(65, 27);
            txtThird.TabIndex = 5;
            txtThird.TextChanged += onValueChanged;
            // 
            // txtFourth
            // 
            txtFourth.Location = new Point(152, 68);
            txtFourth.Name = "txtFourth";
            txtFourth.Size = new Size(65, 27);
            txtFourth.TabIndex = 6;
            txtFourth.TextChanged += onValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "Дробь 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 8;
            label2.Text = "Дробь 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(223, 39);
            label3.Name = "label3";
            label3.Size = new Size(43, 46);
            label3.TabIndex = 9;
            label3.Text = "=";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(395, 132);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFourth);
            Controls.Add(txtThird);
            Controls.Add(comboBox1);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Name = "Form1";
            Text = "Калькулятор";
/*            Load += Form1_Load;
*/            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirst;
        private TextBox txtSecond;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtResult;
        private ComboBox comboBox1;
        private TextBox txtThird;
        private TextBox txtFourth;
        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip2;
    }
}
