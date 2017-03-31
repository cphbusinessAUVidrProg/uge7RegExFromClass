namespace Sofus
{
    partial class RegExTester
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
            this.regExText = new System.Windows.Forms.TextBox();
            this.testText = new System.Windows.Forms.TextBox();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regExText
            // 
            this.regExText.Location = new System.Drawing.Point(165, 52);
            this.regExText.Name = "regExText";
            this.regExText.Size = new System.Drawing.Size(342, 31);
            this.regExText.TabIndex = 0;
            // 
            // testText
            // 
            this.testText.Location = new System.Drawing.Point(165, 122);
            this.testText.Name = "testText";
            this.testText.Size = new System.Drawing.Size(342, 31);
            this.testText.TabIndex = 1;
            this.testText.TextChanged += new System.EventHandler(this.testText_TextChanged);
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(165, 174);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(95, 55);
            this.buttonON.TabIndex = 2;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(405, 174);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(102, 54);
            this.buttonOFF.TabIndex = 3;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reg Expr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test text";
            // 
            // RegExTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.testText);
            this.Controls.Add(this.regExText);
            this.Name = "RegExTester";
            this.Text = "RegExTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regExText;
        private System.Windows.Forms.TextBox testText;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

