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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            CreateMyRichTextBox();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BT_form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CreateMyRichTextBox()
        {
            RT_box.Enabled = false;

            RT_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            RT_box.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            RT_box.SelectionColor = Color.Chocolate;
            RT_box.SelectedText = "      ИНСТРУКЦИЯ. \n\n      Проверка прайса: \n 1.- Проверка прайса реализована для категорий большого прайса. \n\n Обновление прайсов: \n 1.- Внимательно выбирайте категории для обновления. \n\n ";
            RT_box.Text += "     Сохраннения в формате CSV файла для сайта Lepnina.com.ua: \n 1. - После обновления через систему 'Lepnina_updater' зайти в файл и нажать на кнопку сохранить (синяя дискета в левом верхнем углу). \n 2.- Нажать на кнопку закрытия файла, подтверждая выплывающие окна, до момента выбора 'КАК СОХРАНИТЬ'. \n 3.- В окне сохранения выбрать тип сохранения ' CSV (разделители - запятые)(*.csv)'\n  ";
            RT_box.Text += "\n\n     Приятной работы!!!";    
          
        }
    }
}
