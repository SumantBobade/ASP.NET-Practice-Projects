namespace Calculator
{
    partial class Calculator
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
            txtDisplay = new TextBox();
            btn9 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btn0 = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(5, 1);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(303, 89);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn9
            // 
            btn9.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(12, 96);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 62);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(154, 96);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 62);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(12, 172);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 62);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(154, 172);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 62);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Super Funky", 20F, FontStyle.Bold);
            btn3.Location = new Point(12, 250);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 62);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Super Funky", 20F, FontStyle.Bold);
            btn1.Location = new Point(154, 250);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 62);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btn2.Location = new Point(82, 250);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 62);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(82, 96);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 62);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Super Funky", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(82, 172);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 62);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnDiv.Location = new Point(228, 96);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 62);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnMul.Location = new Point(228, 172);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(80, 62);
            btnMul.TabIndex = 11;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnSub.Location = new Point(228, 250);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 62);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(228, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 62);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnEqual.Location = new Point(154, 318);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(68, 62);
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btn0.Location = new Point(82, 318);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 62);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Super Funky", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(12, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 62);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 392);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(txtDisplay);
            Name = "Calculator";
            Text = "Calculator";
            Load += this.Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn9;
        private Button btn7;
        private Button btn6;
        private Button btn4;
        private Button btn3;
        private Button btn1;
        private Button btn2;
        private Button btn8;
        private Button btn5;
        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private Button btnAdd;
        private Button btnEqual;
        private Button btn0;
        private Button btnClear;
    }
}
