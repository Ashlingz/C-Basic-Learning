
namespace WindowsFormsApp1
{
    partial class ParkingTotkal
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
            this.textCheckin = new System.Windows.Forms.TextBox();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.textCheckout = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.textResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // textCheckin
            // 
            this.textCheckin.Location = new System.Drawing.Point(22, 37);
            this.textCheckin.Name = "textCheckin";
            this.textCheckin.ReadOnly = true;
            this.textCheckin.Size = new System.Drawing.Size(445, 31);
            this.textCheckin.TabIndex = 0;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(503, 37);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(118, 31);
            this.btnCheckin.TabIndex = 1;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // textCheckout
            // 
            this.textCheckout.Location = new System.Drawing.Point(22, 90);
            this.textCheckout.Name = "textCheckout";
            this.textCheckout.ReadOnly = true;
            this.textCheckout.Size = new System.Drawing.Size(445, 31);
            this.textCheckout.TabIndex = 2;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(503, 90);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(118, 31);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // textResults
            // 
            this.textResults.Location = new System.Drawing.Point(22, 154);
            this.textResults.Multiline = true;
            this.textResults.Name = "textResults";
            this.textResults.ReadOnly = true;
            this.textResults.Size = new System.Drawing.Size(599, 259);
            this.textResults.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(336, 437);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(131, 31);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // ParkingTotkal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textResults);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.textCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.textCheckin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ParkingTotkal";
            this.Text = "ParkingTotkal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCheckin;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.TextBox textCheckout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox textResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}