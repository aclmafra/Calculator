namespace Calculadora {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textResult = new TextBox();
            btnSeven = new Button();
            btnEight = new Button();
            btnOne = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnNine = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            btnClear = new Button();
            btnAddition = new Button();
            btnEqual = new Button();
            btnZero = new Button();
            btnComma = new Button();
            lblOperation = new Label();
            SuspendLayout();
            // 
            // textResult
            // 
            textResult.Location = new Point(12, 12);
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(222, 23);
            textResult.TabIndex = 0;
            textResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(12, 74);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(51, 49);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(69, 74);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(51, 49);
            btnEight.TabIndex = 2;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(12, 184);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(51, 49);
            btnOne.TabIndex = 3;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(12, 129);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(51, 49);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(69, 129);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(51, 49);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(69, 184);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(51, 49);
            btnTwo.TabIndex = 6;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(126, 184);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(51, 49);
            btnThree.TabIndex = 9;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(126, 129);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(51, 49);
            btnSix.TabIndex = 8;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(126, 74);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(51, 49);
            btnNine.TabIndex = 7;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = Color.Orange;
            btnSubtraction.Location = new Point(183, 184);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(51, 49);
            btnSubtraction.TabIndex = 12;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.Orange;
            btnMultiplication.Location = new Point(183, 129);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(51, 49);
            btnMultiplication.TabIndex = 11;
            btnMultiplication.Text = "X";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.Orange;
            btnDivision.Location = new Point(183, 74);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(51, 49);
            btnDivision.TabIndex = 10;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.Location = new Point(183, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 27);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = Color.Orange;
            btnAddition.Location = new Point(183, 239);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(51, 49);
            btnAddition.TabIndex = 17;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Orange;
            btnEqual.Location = new Point(126, 239);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 49);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(69, 239);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(51, 49);
            btnZero.TabIndex = 15;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnComma
            // 
            btnComma.Location = new Point(12, 239);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(51, 49);
            btnComma.TabIndex = 14;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Location = new Point(15, 16);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(0, 15);
            lblOperation.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(248, 309);
            Controls.Add(lblOperation);
            Controls.Add(btnAddition);
            Controls.Add(btnEqual);
            Controls.Add(btnZero);
            Controls.Add(btnComma);
            Controls.Add(btnClear);
            Controls.Add(btnSubtraction);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnThree);
            Controls.Add(btnSix);
            Controls.Add(btnNine);
            Controls.Add(btnTwo);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnOne);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(textResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResult;
        private Button btnSeven;
        private Button btnEight;
        private Button btnOne;
        private Button btnFour;
        private Button btnFive;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnNine;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private Button btnClear;
        private Button btnAddition;
        private Button btnEqual;
        private Button btnZero;
        private Button btnComma;
        private Label lblOperation;
    }
}
