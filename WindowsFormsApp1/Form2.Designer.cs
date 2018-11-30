namespace WindowsFormsApp1
{
    partial class fArtist
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumberOfConcerts = new System.Windows.Forms.Label();
            this.lbSalaryForConcert = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNumberOfConcerts = new System.Windows.Forms.TextBox();
            this.tbSalaryForConcert = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNumberOfConcerts);
            this.groupBox1.Controls.Add(this.lbSalaryForConcert);
            this.groupBox1.Controls.Add(this.lbGenre);
            this.groupBox1.Controls.Add(this.lbRegion);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.tbNumberOfConcerts);
            this.groupBox1.Controls.Add(this.tbSalaryForConcert);
            this.groupBox1.Controls.Add(this.tbGenre);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // lbNumberOfConcerts
            // 
            this.lbNumberOfConcerts.AutoSize = true;
            this.lbNumberOfConcerts.Location = new System.Drawing.Point(6, 226);
            this.lbNumberOfConcerts.Name = "lbNumberOfConcerts";
            this.lbNumberOfConcerts.Size = new System.Drawing.Size(135, 13);
            this.lbNumberOfConcerts.TabIndex = 10;
            this.lbNumberOfConcerts.Text = "Кількість концертів в турі";
            // 
            // lbSalaryForConcert
            // 
            this.lbSalaryForConcert.AutoSize = true;
            this.lbSalaryForConcert.Location = new System.Drawing.Point(6, 188);
            this.lbSalaryForConcert.Name = "lbSalaryForConcert";
            this.lbSalaryForConcert.Size = new System.Drawing.Size(120, 13);
            this.lbSalaryForConcert.TabIndex = 9;
            this.lbSalaryForConcert.Text = "Зарплатня за концерт";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(6, 152);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 8;
            this.lbGenre.Text = "Жанр";
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(6, 116);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(39, 13);
            this.lbRegion.TabIndex = 7;
            this.lbRegion.Text = "Регіон";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(6, 80);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(41, 13);
            this.lbCountry.TabIndex = 6;
            this.lbCountry.Text = "Країна";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 44);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Ім\'я";
            // 
            // tbNumberOfConcerts
            // 
            this.tbNumberOfConcerts.Location = new System.Drawing.Point(158, 219);
            this.tbNumberOfConcerts.Name = "tbNumberOfConcerts";
            this.tbNumberOfConcerts.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOfConcerts.TabIndex = 5;
            // 
            // tbSalaryForConcert
            // 
            this.tbSalaryForConcert.Location = new System.Drawing.Point(158, 181);
            this.tbSalaryForConcert.Name = "tbSalaryForConcert";
            this.tbSalaryForConcert.Size = new System.Drawing.Size(100, 20);
            this.tbSalaryForConcert.TabIndex = 4;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(158, 145);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 3;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(158, 109);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(100, 20);
            this.tbRegion.TabIndex = 2;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(158, 73);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(158, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWoman);
            this.groupBox2.Controls.Add(this.rbMan);
            this.groupBox2.Location = new System.Drawing.Point(438, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вкажіть стать";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(438, 154);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btClear
            // 
            this.btClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClear.Location = new System.Drawing.Point(554, 155);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Скасувати";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(22, 29);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(65, 17);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Чоловік";
            this.rbMan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(22, 52);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(56, 17);
            this.rbWoman.TabIndex = 1;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Жінка";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // fArtist
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fArtist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про нового артиста";
            this.Load += new System.EventHandler(this.fArtist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNumberOfConcerts;
        private System.Windows.Forms.TextBox tbSalaryForConcert;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbNumberOfConcerts;
        private System.Windows.Forms.Label lbSalaryForConcert;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
    }
}