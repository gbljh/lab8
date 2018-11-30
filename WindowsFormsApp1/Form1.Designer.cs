namespace WindowsFormsApp1
{
    partial class fMain
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
            this.tbArtistInfo = new System.Windows.Forms.TextBox();
            this.btnAddTown = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbArtistInfo
            // 
            this.tbArtistInfo.Location = new System.Drawing.Point(12, 23);
            this.tbArtistInfo.Multiline = true;
            this.tbArtistInfo.Name = "tbArtistInfo";
            this.tbArtistInfo.ReadOnly = true;
            this.tbArtistInfo.Size = new System.Drawing.Size(646, 415);
            this.tbArtistInfo.TabIndex = 0;
            // 
            // btnAddTown
            // 
            this.btnAddTown.Location = new System.Drawing.Point(680, 23);
            this.btnAddTown.Name = "btnAddTown";
            this.btnAddTown.Size = new System.Drawing.Size(94, 32);
            this.btnAddTown.TabIndex = 1;
            this.btnAddTown.Text = "Додати місто";
            this.btnAddTown.UseVisualStyleBackColor = true;
            this.btnAddTown.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(680, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTown);
            this.Controls.Add(this.tbArtistInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота No8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArtistInfo;
        private System.Windows.Forms.Button btnAddTown;
        private System.Windows.Forms.Button btnClose;
    }
}

