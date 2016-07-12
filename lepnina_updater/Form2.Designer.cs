namespace lepnina_updater
{
    partial class Form2
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
            this.RT_box = new System.Windows.Forms.RichTextBox();
            this.BT_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RT_box
            // 
            this.RT_box.Location = new System.Drawing.Point(13, 13);
            this.RT_box.Name = "RT_box";
            this.RT_box.Size = new System.Drawing.Size(555, 415);
            this.RT_box.TabIndex = 0;
            this.RT_box.Text = "";
            // 
            // BT_form2
            // 
            this.BT_form2.Location = new System.Drawing.Point(142, 435);
            this.BT_form2.Name = "BT_form2";
            this.BT_form2.Size = new System.Drawing.Size(312, 23);
            this.BT_form2.TabIndex = 1;
            this.BT_form2.Text = "Закрыть";
            this.BT_form2.UseVisualStyleBackColor = true;
            this.BT_form2.Click += new System.EventHandler(this.BT_form2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this.BT_form2);
            this.Controls.Add(this.RT_box);
            this.Name = "Form2";
            this.Text = "Инструкция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RT_box;
        private System.Windows.Forms.Button BT_form2;
    }
}