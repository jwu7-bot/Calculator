namespace Calculator
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
            txtDisplay = new TextBox();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnZero = new Button();
            btnComma = new Button();
            btnEquals = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnClear = new Button();
            label1 = new Label();
            lblOperation = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(18, 21);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(240, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(18, 145);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(47, 45);
            btnFour.TabIndex = 1;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(82, 145);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(47, 45);
            btnFive.TabIndex = 2;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(147, 145);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(47, 45);
            btnSix.TabIndex = 3;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(18, 94);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(47, 45);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(82, 94);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(47, 45);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(147, 94);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(47, 45);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(18, 196);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(47, 45);
            btnOne.TabIndex = 7;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(82, 196);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(47, 45);
            btnTwo.TabIndex = 8;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(147, 196);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(47, 45);
            btnThree.TabIndex = 9;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(82, 247);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(47, 45);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnComma
            // 
            btnComma.Location = new Point(18, 247);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(47, 45);
            btnComma.TabIndex = 11;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(147, 247);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(47, 45);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(209, 94);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(47, 45);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnTimes
            // 
            btnTimes.Location = new Point(209, 145);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(47, 45);
            btnTimes.TabIndex = 14;
            btnTimes.Text = "x";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(209, 196);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(47, 45);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(209, 247);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(47, 45);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(209, 59);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 29);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Location = new Point(22, 25);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(0, 15);
            lblOperation.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 311);
            Controls.Add(lblOperation);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnTimes);
            Controls.Add(btnDivide);
            Controls.Add(btnEquals);
            Controls.Add(btnComma);
            Controls.Add(btnZero);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(txtDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnZero;
        private Button btnComma;
        private Button btnEquals;
        private Button btnDivide;
        private Button btnTimes;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnClear;
        private Label label1;
        private Label lblOperation;
    }
}
