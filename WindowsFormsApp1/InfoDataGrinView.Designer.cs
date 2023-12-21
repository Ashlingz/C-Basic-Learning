
namespace WindowsFormsApp1
{
    partial class InfoDataGrinView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDataGrinView));
            this.data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.GroupBox();
            this.rOther = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.gen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.data.Location = new System.Drawing.Point(39, 162);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 100;
            this.data.RowTemplate.Height = 60;
            this.data.Size = new System.Drawing.Size(904, 325);
            this.data.TabIndex = 0;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            this.data.SelectionChanged += new System.EventHandler(this.data_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Photo";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // btnEditt
            // 
            this.btnEditt.Location = new System.Drawing.Point(861, 25);
            this.btnEditt.Name = "btnEditt";
            this.btnEditt.Size = new System.Drawing.Size(106, 62);
            this.btnEditt.TabIndex = 21;
            this.btnEditt.Text = "Edit";
            this.btnEditt.UseVisualStyleBackColor = true;
            this.btnEditt.Click += new System.EventHandler(this.btnEditt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(861, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 62);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gen
            // 
            this.gen.Controls.Add(this.rOther);
            this.gen.Controls.Add(this.rFemale);
            this.gen.Controls.Add(this.rMale);
            this.gen.Location = new System.Drawing.Point(418, 9);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(171, 147);
            this.gen.TabIndex = 18;
            this.gen.TabStop = false;
            this.gen.Text = "Gender";
            // 
            // rOther
            // 
            this.rOther.AutoSize = true;
            this.rOther.Location = new System.Drawing.Point(10, 99);
            this.rOther.Name = "rOther";
            this.rOther.Size = new System.Drawing.Size(83, 29);
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
            this.rFemale.Size = new System.Drawing.Size(101, 29);
            this.rFemale.TabIndex = 7;
            this.rFemale.TabStop = true;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(10, 34);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(77, 29);
            this.rMale.TabIndex = 0;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(88, 120);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(324, 35);
            this.addresstxt.TabIndex = 17;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(8, 118);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(79, 25);
            this.txt3.TabIndex = 16;
            this.txt3.Text = "Adress";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(88, 62);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(324, 35);
            this.nametxt.TabIndex = 15;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(8, 59);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(68, 25);
            this.txt2.TabIndex = 14;
            this.txt2.Text = "Name";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(88, 9);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(324, 35);
            this.idtxt.TabIndex = 13;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(8, 6);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(32, 25);
            this.txt1.TabIndex = 12;
            this.txt1.Text = "ID";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(632, 6);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(223, 144);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // InfoDataGrinView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 493);
            this.Controls.Add(this.btnEditt);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.data);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InfoDataGrinView";
            this.Text = "InfoDataGrinView";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.gen.ResumeLayout(false);
            this.gen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnEditt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gen;
        private System.Windows.Forms.RadioButton rOther;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}