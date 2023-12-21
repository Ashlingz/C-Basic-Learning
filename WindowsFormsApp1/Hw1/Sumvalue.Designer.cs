
namespace WindowsFormsApp1
{
    partial class back
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
            this.sumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.value3 = new System.Windows.Forms.TextBox();
            this.exitb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumb
            // 
            this.sumb.Location = new System.Drawing.Point(240, 133);
            this.sumb.Name = "sumb";
            this.sumb.Size = new System.Drawing.Size(115, 48);
            this.sumb.TabIndex = 0;
            this.sumb.Text = "Sum";
            this.sumb.UseVisualStyleBackColor = true;
            this.sumb.Click += new System.EventHandler(this.sumb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value1:";
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(141, 9);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(348, 44);
            this.value1.TabIndex = 2;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(141, 70);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(348, 44);
            this.value2.TabIndex = 11;
            this.value2.TextChanged += new System.EventHandler(this.value2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Value2:";
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(141, 187);
            this.value3.Multiline = true;
            this.value3.Name = "value3";
            this.value3.ReadOnly = true;
            this.value3.Size = new System.Drawing.Size(348, 327);
            this.value3.TabIndex = 13;
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(141, 539);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(115, 63);
            this.exitb.TabIndex = 14;
            this.exitb.Text = "Exit";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "back";
            this.Text = "Sumvalue";
            this.Load += new System.EventHandler(this.Sumvalue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button button1;
    }
}