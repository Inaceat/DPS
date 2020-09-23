namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fooInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.threadsInput = new System.Windows.Forms.TextBox();
            this.aInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fooInput
            // 
            this.fooInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fooInput.FormattingEnabled = true;
            this.fooInput.Items.AddRange(new object[] {
            "(e^x) * sin(y)",
            "sin(x+2y)",
            "cos(x·e^y)",
            "exp(cos(x^2+y)), exp(z) = e^z"});
            this.fooInput.Location = new System.Drawing.Point(266, 9);
            this.fooInput.Name = "fooInput";
            this.fooInput.Size = new System.Drawing.Size(121, 21);
            this.fooInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Threads:";
            // 
            // threadsInput
            // 
            this.threadsInput.Location = new System.Drawing.Point(86, 9);
            this.threadsInput.Name = "threadsInput";
            this.threadsInput.Size = new System.Drawing.Size(100, 20);
            this.threadsInput.TabIndex = 2;
            this.threadsInput.Text = "2";
            this.threadsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(88, 56);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(76, 20);
            this.aInput.TabIndex = 4;
            this.aInput.Text = "1";
            this.aInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a:";
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(192, 56);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(76, 20);
            this.bInput.TabIndex = 6;
            this.bInput.Text = "2";
            this.bInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b:";
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(296, 56);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(56, 20);
            this.nInput.TabIndex = 8;
            this.nInput.Text = "10";
            this.nInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "n:";
            // 
            // mInput
            // 
            this.mInput.Location = new System.Drawing.Point(296, 82);
            this.mInput.Name = "mInput";
            this.mInput.Size = new System.Drawing.Size(56, 20);
            this.mInput.TabIndex = 14;
            this.mInput.Text = "10";
            this.mInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "m:";
            // 
            // dInput
            // 
            this.dInput.Location = new System.Drawing.Point(192, 82);
            this.dInput.Name = "dInput";
            this.dInput.Size = new System.Drawing.Size(76, 20);
            this.dInput.TabIndex = 12;
            this.dInput.Text = "4";
            this.dInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "d:";
            // 
            // cInput
            // 
            this.cInput.Location = new System.Drawing.Point(88, 82);
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(76, 20);
            this.cInput.TabIndex = 10;
            this.cInput.Text = "3";
            this.cInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "c:";
            // 
            // resultOutput
            // 
            this.resultOutput.Enabled = false;
            this.resultOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.resultOutput.Location = new System.Drawing.Point(146, 196);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(176, 20);
            this.resultOutput.TabIndex = 15;
            this.resultOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Function:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 259);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.mInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threadsInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fooInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fooInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox threadsInput;
        private System.Windows.Forms.TextBox aInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

