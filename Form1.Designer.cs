namespace FrmCalculator
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
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(262, 36);
            txtBoxInput1.Multiline = true;
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(229, 34);
            txtBoxInput1.TabIndex = 0;
            txtBoxInput1.TextChanged += txtBoxInput1_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "/", "+", "-", "*" });
            cbOperator.Location = new Point(293, 93);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(151, 28);
            cbOperator.TabIndex = 1;
            cbOperator.SelectedIndexChanged += cbOperator_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.2F);
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter first number: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.2F);
            label2.Location = new Point(30, 143);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter second number: ";
            label2.Click += label2_Click;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(262, 140);
            txtBoxInput2.Multiline = true;
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(229, 34);
            txtBoxInput2.TabIndex = 3;
            txtBoxInput2.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.2F);
            label4.Location = new Point(154, 200);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Answer: ";
            label4.Click += label4_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Consolas", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDisplayTotal.Location = new Point(262, 200);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(54, 20);
            lblDisplayTotal.TabIndex = 7;
            lblDisplayTotal.Text = "00.00";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(381, 233);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 35);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 322);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxInput2);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "FrmCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label label1;
        private Label label2;
        private TextBox txtBoxInput2;
        private Label label3;
        private Label label4;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
