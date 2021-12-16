namespace Temperature_Calculator
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
            this.buttonConvertC = new System.Windows.Forms.Button();
            this.buttonConvertF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConvertC
            // 
            this.buttonConvertC.Location = new System.Drawing.Point(193, 48);
            this.buttonConvertC.Name = "buttonConvertC";
            this.buttonConvertC.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertC.TabIndex = 0;
            this.buttonConvertC.Text = "Convert";
            this.buttonConvertC.UseVisualStyleBackColor = true;
            this.buttonConvertC.Click += new System.EventHandler(this.buttonConvertC_Click);
            // 
            // buttonConvertF
            // 
            this.buttonConvertF.Location = new System.Drawing.Point(193, 92);
            this.buttonConvertF.Name = "buttonConvertF";
            this.buttonConvertF.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertF.TabIndex = 1;
            this.buttonConvertF.Text = "Convert";
            this.buttonConvertF.UseVisualStyleBackColor = true;
            this.buttonConvertF.Click += new System.EventHandler(this.buttonConvertF_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "F";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(43, 49);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 4;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(43, 93);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 23);
            this.textBoxF.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvertF);
            this.Controls.Add(this.buttonConvertC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConvertC;
        private Button buttonConvertF;
        private Label label1;
        private Label label2;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Button button1;
    }
}