
namespace WindowsFormsApp1
{
    partial class Salary1
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
            this.Exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.TextBox();
            this.totalh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.ttax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(585, 258);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(114, 44);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(585, 20);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(114, 44);
            this.clear.TabIndex = 10;
            this.clear.Text = "Total";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(27, 66);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.Size = new System.Drawing.Size(514, 531);
            this.show.TabIndex = 8;
            // 
            // totalh
            // 
            this.totalh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalh.Location = new System.Drawing.Point(153, 20);
            this.totalh.Multiline = true;
            this.totalh.Name = "totalh";
            this.totalh.Size = new System.Drawing.Size(388, 31);
            this.totalh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Hour";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(585, 208);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(114, 44);
            this.logout.TabIndex = 12;
            this.logout.Text = "Back";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ttax
            // 
            this.ttax.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttax.Location = new System.Drawing.Point(585, 82);
            this.ttax.Name = "ttax";
            this.ttax.Size = new System.Drawing.Size(114, 44);
            this.ttax.TabIndex = 13;
            this.ttax.Text = "To Tax";
            this.ttax.UseVisualStyleBackColor = true;
            this.ttax.Click += new System.EventHandler(this.ttax_Click);
            // 
            // Salary1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 353);
            this.Controls.Add(this.ttax);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.show);
            this.Controls.Add(this.totalh);
            this.Controls.Add(this.label1);
            this.Name = "Salary1";
            this.Text = "Salary1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.TextBox totalh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button ttax;
    }
}