using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lepnina_updater
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CreateMyRichTextBox();
        }

        public void CreateMyRichTextBox()
        {
            RT_box2.Enabled = false;

            RT_box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            RT_box2.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
            RT_box2.SelectionColor = Color.DarkGreen;
            RT_box2.SelectedText = " \n   Creater: \n\n\n      Аркуша Артем (Junior C#) \n\n                    Май 2016 ";
           
        }
    }
}
