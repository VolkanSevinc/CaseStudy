namespace NumberConverter
{
    partial class MainPanel
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
            this.txtBxInput1 = new System.Windows.Forms.TextBox();
            this.txtBxInput2 = new System.Windows.Forms.TextBox();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.radBritish = new System.Windows.Forms.RadioButton();
            this.radAmerican = new System.Windows.Forms.RadioButton();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.pnlRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxInput1
            // 
            this.txtBxInput1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBxInput1.Location = new System.Drawing.Point(85, 58);
            this.txtBxInput1.Name = "txtBxInput1";
            this.txtBxInput1.Size = new System.Drawing.Size(625, 20);
            this.txtBxInput1.TabIndex = 0;
            this.txtBxInput1.Text = "Please enter first number in written form";
            this.txtBxInput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBxInput1.Enter += new System.EventHandler(this.Text_Enter1);
            this.txtBxInput1.Leave += new System.EventHandler(this.Text_Exit1);
            // 
            // txtBxInput2
            // 
            this.txtBxInput2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBxInput2.Location = new System.Drawing.Point(85, 124);
            this.txtBxInput2.Name = "txtBxInput2";
            this.txtBxInput2.Size = new System.Drawing.Size(625, 20);
            this.txtBxInput2.TabIndex = 1;
            this.txtBxInput2.Text = "Please enter second number in written form";
            this.txtBxInput2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBxInput2.Enter += new System.EventHandler(this.Text_Enter2);
            this.txtBxInput2.Leave += new System.EventHandler(this.Text_Exit2);
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(85, 192);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.ReadOnly = true;
            this.txtBxResult.Size = new System.Drawing.Size(625, 20);
            this.txtBxResult.TabIndex = 2;
            this.txtBxResult.Text = "Result";
            this.txtBxResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlus.Location = new System.Drawing.Point(85, 326);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(110, 90);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinus.Location = new System.Drawing.Point(256, 326);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(110, 90);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiplication.Location = new System.Drawing.Point(430, 326);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(110, 90);
            this.btnMultiplication.TabIndex = 5;
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDivision.Location = new System.Drawing.Point(600, 326);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(110, 90);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.button4_Click);
            // 
            // radBritish
            // 
            this.radBritish.AutoSize = true;
            this.radBritish.Checked = true;
            this.radBritish.Location = new System.Drawing.Point(3, 13);
            this.radBritish.Name = "radBritish";
            this.radBritish.Size = new System.Drawing.Size(90, 17);
            this.radBritish.TabIndex = 7;
            this.radBritish.TabStop = true;
            this.radBritish.Text = "British English";
            this.radBritish.UseVisualStyleBackColor = true;
            this.radBritish.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radAmerican
            // 
            this.radAmerican.AutoSize = true;
            this.radAmerican.Location = new System.Drawing.Point(3, 36);
            this.radAmerican.Name = "radAmerican";
            this.radAmerican.Size = new System.Drawing.Size(106, 17);
            this.radAmerican.TabIndex = 8;
            this.radAmerican.Text = "American English";
            this.radAmerican.UseVisualStyleBackColor = true;
            this.radAmerican.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Controls.Add(this.radBritish);
            this.pnlRadioButtons.Controls.Add(this.radAmerican);
            this.pnlRadioButtons.Location = new System.Drawing.Point(85, 228);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(200, 79);
            this.pnlRadioButtons.TabIndex = 10;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.txtBxInput2);
            this.Controls.Add(this.txtBxInput1);
            this.Name = "MainPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInput1;
        private System.Windows.Forms.TextBox txtBxInput2;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.RadioButton radBritish;
        private System.Windows.Forms.RadioButton radAmerican;
        private System.Windows.Forms.Panel pnlRadioButtons;
    }
}