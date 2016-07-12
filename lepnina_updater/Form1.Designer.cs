namespace lepnina_updater
{
    partial class Lepnina_updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lepnina_updater));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_refresh = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.TB_base_info1 = new System.Windows.Forms.TextBox();
            this.TB_price_info1 = new System.Windows.Forms.TextBox();
            this.BT_base_load1 = new System.Windows.Forms.Button();
            this.BT_price_load1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_refresh2 = new System.Windows.Forms.Button();
            this.PB_updater = new System.Windows.Forms.ProgressBar();
            this.BT_updater = new System.Windows.Forms.Button();
            this.TB_price_load2 = new System.Windows.Forms.TextBox();
            this.BT_price_load2 = new System.Windows.Forms.Button();
            this.RB_internet = new System.Windows.Forms.RadioButton();
            this.RB_mini_price = new System.Windows.Forms.RadioButton();
            this.RB_big_price = new System.Windows.Forms.RadioButton();
            this.TB_base_load2 = new System.Windows.Forms.TextBox();
            this.BT_base_load2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_refresh);
            this.groupBox1.Controls.Add(this.button_Check);
            this.groupBox1.Controls.Add(this.TB_base_info1);
            this.groupBox1.Controls.Add(this.TB_price_info1);
            this.groupBox1.Controls.Add(this.BT_base_load1);
            this.groupBox1.Controls.Add(this.BT_price_load1);
            this.groupBox1.Location = new System.Drawing.Point(36, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПРОВЕРКА ПРАЙСА С СИСТЕМОЙ";
            // 
            // BT_refresh
            // 
            this.BT_refresh.Location = new System.Drawing.Point(209, 39);
            this.BT_refresh.Name = "BT_refresh";
            this.BT_refresh.Size = new System.Drawing.Size(55, 50);
            this.BT_refresh.TabIndex = 5;
            this.BT_refresh.Text = "Refresh";
            this.BT_refresh.UseVisualStyleBackColor = true;
            this.BT_refresh.Click += new System.EventHandler(this.BT_refresh_Click);
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.Coral;
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Check.Location = new System.Drawing.Point(21, 96);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(430, 36);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Проверить";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // TB_base_info1
            // 
            this.TB_base_info1.Location = new System.Drawing.Point(270, 69);
            this.TB_base_info1.Name = "TB_base_info1";
            this.TB_base_info1.ReadOnly = true;
            this.TB_base_info1.Size = new System.Drawing.Size(181, 20);
            this.TB_base_info1.TabIndex = 3;
            // 
            // TB_price_info1
            // 
            this.TB_price_info1.Location = new System.Drawing.Point(21, 69);
            this.TB_price_info1.Name = "TB_price_info1";
            this.TB_price_info1.ReadOnly = true;
            this.TB_price_info1.Size = new System.Drawing.Size(181, 20);
            this.TB_price_info1.TabIndex = 2;
            // 
            // BT_base_load1
            // 
            this.BT_base_load1.Location = new System.Drawing.Point(270, 39);
            this.BT_base_load1.Name = "BT_base_load1";
            this.BT_base_load1.Size = new System.Drawing.Size(181, 23);
            this.BT_base_load1.TabIndex = 1;
            this.BT_base_load1.Text = "Загрузить Базу (Lepnina)";
            this.BT_base_load1.UseVisualStyleBackColor = true;
            this.BT_base_load1.Click += new System.EventHandler(this.base_load1_Click);
            // 
            // BT_price_load1
            // 
            this.BT_price_load1.Location = new System.Drawing.Point(21, 39);
            this.BT_price_load1.Name = "BT_price_load1";
            this.BT_price_load1.Size = new System.Drawing.Size(181, 23);
            this.BT_price_load1.TabIndex = 0;
            this.BT_price_load1.Text = "Загрузить Прайс";
            this.BT_price_load1.UseVisualStyleBackColor = true;
            this.BT_price_load1.Click += new System.EventHandler(this.price_load1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lepnina_updater.Properties.Resources.Логотип_copy___копия;
            this.panel1.Location = new System.Drawing.Point(115, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 158);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_refresh2);
            this.groupBox2.Controls.Add(this.PB_updater);
            this.groupBox2.Controls.Add(this.BT_updater);
            this.groupBox2.Controls.Add(this.TB_price_load2);
            this.groupBox2.Controls.Add(this.BT_price_load2);
            this.groupBox2.Controls.Add(this.RB_internet);
            this.groupBox2.Controls.Add(this.RB_mini_price);
            this.groupBox2.Controls.Add(this.RB_big_price);
            this.groupBox2.Controls.Add(this.TB_base_load2);
            this.groupBox2.Controls.Add(this.BT_base_load2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(36, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОБНОВЛЕНИЕ ПРАЙСОВ";
            // 
            // BT_refresh2
            // 
            this.BT_refresh2.Location = new System.Drawing.Point(209, 29);
            this.BT_refresh2.Name = "BT_refresh2";
            this.BT_refresh2.Size = new System.Drawing.Size(55, 49);
            this.BT_refresh2.TabIndex = 12;
            this.BT_refresh2.Text = "Refresh";
            this.BT_refresh2.UseVisualStyleBackColor = true;
            this.BT_refresh2.Click += new System.EventHandler(this.BT_refresh2_Click);
            // 
            // PB_updater
            // 
            this.PB_updater.Location = new System.Drawing.Point(21, 185);
            this.PB_updater.Name = "PB_updater";
            this.PB_updater.Size = new System.Drawing.Size(430, 23);
            this.PB_updater.TabIndex = 11;
            // 
            // BT_updater
            // 
            this.BT_updater.BackColor = System.Drawing.Color.Coral;
            this.BT_updater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_updater.Location = new System.Drawing.Point(270, 84);
            this.BT_updater.Name = "BT_updater";
            this.BT_updater.Size = new System.Drawing.Size(181, 95);
            this.BT_updater.TabIndex = 10;
            this.BT_updater.Text = "ОБНОВИТЬ";
            this.BT_updater.UseVisualStyleBackColor = false;
            this.BT_updater.Click += new System.EventHandler(this.BT_updater_Click);
            // 
            // TB_price_load2
            // 
            this.TB_price_load2.Location = new System.Drawing.Point(270, 58);
            this.TB_price_load2.Name = "TB_price_load2";
            this.TB_price_load2.ReadOnly = true;
            this.TB_price_load2.Size = new System.Drawing.Size(181, 20);
            this.TB_price_load2.TabIndex = 5;
            // 
            // BT_price_load2
            // 
            this.BT_price_load2.Location = new System.Drawing.Point(270, 29);
            this.BT_price_load2.Name = "BT_price_load2";
            this.BT_price_load2.Size = new System.Drawing.Size(181, 23);
            this.BT_price_load2.TabIndex = 9;
            this.BT_price_load2.Text = "Загрузить Прайс";
            this.BT_price_load2.UseVisualStyleBackColor = true;
            this.BT_price_load2.Click += new System.EventHandler(this.BT_price_load2_Click);
            // 
            // RB_internet
            // 
            this.RB_internet.AutoSize = true;
            this.RB_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB_internet.Location = new System.Drawing.Point(21, 160);
            this.RB_internet.Name = "RB_internet";
            this.RB_internet.Size = new System.Drawing.Size(134, 19);
            this.RB_internet.TabIndex = 8;
            this.RB_internet.TabStop = true;
            this.RB_internet.Text = "Интеренет сайт";
            this.RB_internet.UseVisualStyleBackColor = true;
            this.RB_internet.CheckedChanged += new System.EventHandler(this.RB_internet_CheckedChanged);
            // 
            // RB_mini_price
            // 
            this.RB_mini_price.AutoSize = true;
            this.RB_mini_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB_mini_price.Location = new System.Drawing.Point(21, 135);
            this.RB_mini_price.Name = "RB_mini_price";
            this.RB_mini_price.Size = new System.Drawing.Size(105, 19);
            this.RB_mini_price.TabIndex = 7;
            this.RB_mini_price.TabStop = true;
            this.RB_mini_price.Text = "Мини-прайс";
            this.RB_mini_price.UseVisualStyleBackColor = true;
            this.RB_mini_price.CheckedChanged += new System.EventHandler(this.RB_mini_price_CheckedChanged);
            // 
            // RB_big_price
            // 
            this.RB_big_price.AutoSize = true;
            this.RB_big_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB_big_price.Location = new System.Drawing.Point(21, 110);
            this.RB_big_price.Name = "RB_big_price";
            this.RB_big_price.Size = new System.Drawing.Size(133, 19);
            this.RB_big_price.TabIndex = 6;
            this.RB_big_price.TabStop = true;
            this.RB_big_price.Text = "Основной прайс";
            this.RB_big_price.UseVisualStyleBackColor = true;
            this.RB_big_price.CheckedChanged += new System.EventHandler(this.RB_big_price_CheckedChanged);
            // 
            // TB_base_load2
            // 
            this.TB_base_load2.Location = new System.Drawing.Point(21, 84);
            this.TB_base_load2.Name = "TB_base_load2";
            this.TB_base_load2.ReadOnly = true;
            this.TB_base_load2.Size = new System.Drawing.Size(181, 20);
            this.TB_base_load2.TabIndex = 5;
            // 
            // BT_base_load2
            // 
            this.BT_base_load2.Location = new System.Drawing.Point(21, 29);
            this.BT_base_load2.Name = "BT_base_load2";
            this.BT_base_load2.Size = new System.Drawing.Size(181, 49);
            this.BT_base_load2.TabIndex = 0;
            this.BT_base_load2.Text = "Загрузить Базу (Lepnina)";
            this.BT_base_load2.UseVisualStyleBackColor = true;
            this.BT_base_load2.Click += new System.EventHandler(this.BT_base_load2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "CopyRights (c) Arkusha Artem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(458, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "All Rights Reserved";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.createrToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // createrToolStripMenuItem
            // 
            this.createrToolStripMenuItem.Name = "createrToolStripMenuItem";
            this.createrToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createrToolStripMenuItem.Text = "Creater";
            this.createrToolStripMenuItem.Click += new System.EventHandler(this.createrToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Lepnina_updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(546, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lepnina_updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lepnina_updater";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_price_load1;
        private System.Windows.Forms.Button BT_base_load1;
        private System.Windows.Forms.TextBox TB_base_info1;
        private System.Windows.Forms.TextBox TB_price_info1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_base_load2;
        private System.Windows.Forms.TextBox TB_base_load2;
        private System.Windows.Forms.Button BT_updater;
        private System.Windows.Forms.TextBox TB_price_load2;
        private System.Windows.Forms.Button BT_price_load2;
        private System.Windows.Forms.RadioButton RB_internet;
        private System.Windows.Forms.RadioButton RB_mini_price;
        private System.Windows.Forms.RadioButton RB_big_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PB_updater;
        private System.Windows.Forms.Button BT_refresh;
        private System.Windows.Forms.Button BT_refresh2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

