
namespace WindowsFormsApp1
{
    partial class InputInfor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputInfor));
            this.txt1 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.GroupBox();
            this.rOther = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnEditt = new System.Windows.Forms.Button();
            this.gen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(11, 9);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(43, 38);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "ID";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(91, 12);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(324, 35);
            this.idtxt.TabIndex = 1;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(91, 65);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(324, 35);
            this.nametxt.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(11, 62);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(73, 38);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "Name";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(91, 123);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(324, 35);
            this.addresstxt.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(11, 121);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(86, 38);
            this.txt3.TabIndex = 4;
            this.txt3.Text = "Adress";
            // 
            // gen
            // 
            this.gen.Controls.Add(this.rOther);
            this.gen.Controls.Add(this.rFemale);
            this.gen.Controls.Add(this.rMale);
            this.gen.Location = new System.Drawing.Point(421, 12);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(171, 147);
            this.gen.TabIndex = 6;
            this.gen.TabStop = false;
            this.gen.Text = "Gender";
            // 
            // rOther
            // 
            this.rOther.AutoSize = true;
            this.rOther.Location = new System.Drawing.Point(10, 99);
            this.rOther.Name = "rOther";
            this.rOther.Size = new System.Drawing.Size(96, 42);
            this.rOther.TabIndex = 7;
            this.rOther.TabStop = true;
            this.rOther.Text = "Other";
            this.rOther.UseVisualStyleBackColor = true;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Location = new System.Drawing.Point(10, 66);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(105, 42);
            this.rFemale.TabIndex = 7;
            this.rFemale.TabStop = true;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            this.rFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(10, 34);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(83, 42);
            this.rMale.TabIndex = 0;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list.HideSelection = false;
            this.list.LargeImageList = this.imageList1;
            this.list.Location = new System.Drawing.Point(20, 165);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(951, 220);
            this.list.SmallImageList = this.imageList1;
            this.list.TabIndex = 9;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Photo";
            this.columnHeader5.Width = 148;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 291;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Gender";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 158;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(635, 9);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(223, 144);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // btnEditt
            // 
            this.btnEditt.Location = new System.Drawing.Point(864, 28);
            this.btnEditt.Name = "btnEditt";
            this.btnEditt.Size = new System.Drawing.Size(106, 62);
            this.btnEditt.TabIndex = 11;
            this.btnEditt.Text = "Edit";
            this.btnEditt.UseVisualStyleBackColor = true;
            this.btnEditt.Click += new System.EventHandler(this.btnEditt_Click);
            // 
            // InputInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 392);
            this.Controls.Add(this.btnEditt);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.txt1);
            this.Font = new System.Drawing.Font("AKbalthom Freehand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "InputInfor";
            this.Text = "InputInfor";
            this.gen.ResumeLayout(false);
            this.gen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.GroupBox gen;
        private System.Windows.Forms.RadioButton rOther;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnEditt;
    }
}