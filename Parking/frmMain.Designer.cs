namespace Parking
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.کاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکاربرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتشخصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستاشخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خودروهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کاربرانToolStripMenuItem,
            this.خودروهاToolStripMenuItem,
            this.گزارشاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // کاربرانToolStripMenuItem
            // 
            this.کاربرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتکاربرToolStripMenuItem,
            this.لیستکاربرانToolStripMenuItem,
            this.ثبتشخصToolStripMenuItem,
            this.لیستاشخاصToolStripMenuItem});
            this.کاربرانToolStripMenuItem.Name = "کاربرانToolStripMenuItem";
            this.کاربرانToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.کاربرانToolStripMenuItem.Text = "کاربران";
            this.کاربرانToolStripMenuItem.Click += new System.EventHandler(this.کاربرانToolStripMenuItem_Click);
            // 
            // ثبتکاربرToolStripMenuItem
            // 
            this.ثبتکاربرToolStripMenuItem.Name = "ثبتکاربرToolStripMenuItem";
            this.ثبتکاربرToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ثبتکاربرToolStripMenuItem.Text = "ثبت کاربر";
            this.ثبتکاربرToolStripMenuItem.Click += new System.EventHandler(this.ثبتکاربرToolStripMenuItem_Click);
            // 
            // لیستکاربرانToolStripMenuItem
            // 
            this.لیستکاربرانToolStripMenuItem.Name = "لیستکاربرانToolStripMenuItem";
            this.لیستکاربرانToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.لیستکاربرانToolStripMenuItem.Text = "لیست کاربران";
            this.لیستکاربرانToolStripMenuItem.Click += new System.EventHandler(this.لیستکاربرانToolStripMenuItem_Click);
            // 
            // ثبتشخصToolStripMenuItem
            // 
            this.ثبتشخصToolStripMenuItem.Name = "ثبتشخصToolStripMenuItem";
            this.ثبتشخصToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ثبتشخصToolStripMenuItem.Text = "ثبت شخص";
            this.ثبتشخصToolStripMenuItem.Click += new System.EventHandler(this.ثبتشخصToolStripMenuItem_Click);
            // 
            // لیستاشخاصToolStripMenuItem
            // 
            this.لیستاشخاصToolStripMenuItem.Name = "لیستاشخاصToolStripMenuItem";
            this.لیستاشخاصToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.لیستاشخاصToolStripMenuItem.Text = "لیست اشخاص";
            this.لیستاشخاصToolStripMenuItem.Click += new System.EventHandler(this.لیستاشخاصToolStripMenuItem_Click);
            // 
            // خودروهاToolStripMenuItem
            // 
            this.خودروهاToolStripMenuItem.Name = "خودروهاToolStripMenuItem";
            this.خودروهاToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.خودروهاToolStripMenuItem.Text = "خودروها";
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار پارکینگ";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتکاربرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خودروهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتشخصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستاشخاصToolStripMenuItem;
    }
}