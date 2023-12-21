
namespace WindowsFormsApp1
{
    partial class BDandPT
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
            this.BD = new System.Windows.Forms.Button();
            this.PT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BD
            // 
            this.BD.Location = new System.Drawing.Point(105, 63);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(139, 87);
            this.BD.TabIndex = 0;
            this.BD.Text = "Date";
            this.BD.UseVisualStyleBackColor = true;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            // 
            // PT
            // 
            this.PT.Location = new System.Drawing.Point(318, 63);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(139, 87);
            this.PT.TabIndex = 1;
            this.PT.Text = "PakingTotal";
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.PT_Click);
            // 
            // BDandPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 255);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.BD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BDandPT";
            this.Text = "BDandPT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BD;
        private System.Windows.Forms.Button PT;
    }
}