using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace lepnina_updater
{
    public partial class Lepnina_updater : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string name_way_base_price;
        string name_way_big_price;

        bool prop_base = false;
      
        string mess_text = "";
 
        public Lepnina_updater()
        {
            InitializeComponent();
            button_Check.Enabled = false;
            BT_updater.Enabled = false;
            PB_updater.Value = 0;
            PB_updater.Maximum = 100;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void price_load1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            ofd.Filter = "All file EXCEL|*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TB_price_info1.Text = ofd.SafeFileName;
                            name_way_big_price = ofd.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Close file *.xlsx! Original error: " + ex.Message);
                }

                //MessageBox.Show(name_way_base);
            }
            if (TB_price_info1.Text != "") prop_base = true;
        } // price_load1_Click

        private void system_price_load1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            ofd.Filter = "All file EXCEL|*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TB_base_info1.Text = ofd.SafeFileName;
                            name_way_base_price = ofd.FileName;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Close file *.xlsx! Original error: " + ex.Message);
                }


            }
            if (TB_base_info1.Text != "" && prop_base == true) button_Check.Enabled = true;
        } // system_price_load1_Click

        private void Check_Click(object sender, EventArgs e)
        {

            List<Price> arr_big_price = read_excel_file(name_way_big_price, "big_price");
            List<Price> arr_base_price = read_excel_file(name_way_base_price, "base_price");
      
            if (arr_big_price != null && arr_base_price != null)
            {
                list_info(arr_big_price, arr_base_price);
            }
            if (mess_text != "") MessageBox.Show(mess_text + "\n ----------------------------------------------------------- \n ИСПРАВТЕ ИНФОРМАЦИЮ В ПРАЙСЕ И СИСТЕМЕ!!!\n -----------------------------------------------------------", "ОЧЕНЬ ВАЖНО!!!");
            else MessageBox.Show("Повторений нету, проверте следующий прайс!!!", "ОЧЕНЬ ВАЖНО!!!");
            
            TB_base_info1.Clear();
            TB_price_info1.Clear();
            button_Check.Enabled = false;
            mess_text = "";

        } // Check_Click
        
        private List <Price> read_excel_file(string file_way, string arg_way)
        {
            var package = new ExcelPackage(new FileInfo(file_way));

            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            List <Price> tamp = new List <Price>();

            int[] arr = new int[3];
            array_choose_if(arg_way, arr, workSheet);
        
            for (int i = arr[0]; i <= workSheet.Dimension.End.Row; i++)
            {
                if (workSheet.Cells[i, arr[1], i, arr[2]].Merge == true)
                {
                   continue;
                }
                if (workSheet.Cells[i, arr[1]].Text != "" )
                   tamp.Add(new Price() { name_id = workSheet.Cells[i, arr[1]].Text, price =  workSheet.Cells[i, arr[2]].Text });
               
            }
            //Array.Resize(ref tamp, j);

            return tamp;
        } // read_excel_file

        private void list_info(List<Price> big_price, List<Price> base_price)
        {
                       
            for (int i = 0; i < big_price.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < base_price.Count; j++)
                {
                    if (big_price[i].name_id == base_price[j].name_id && base_price[j].price != "")
                    {
                        count++;
                    }
                   
                    
                }
                if (count != 1)
                {
                    mess_text = mess_text + big_price[i].name_id + " " + big_price[i].price + " \t";
                }
                
            }
            if (mess_text != "") mess_text = "Такие товары встречаются 0 или больше 1-го раза: \n--------------------------------------------------------------\n" + mess_text;
            
     
        }//list_info

        private void array_choose_if(string str, int[] arr, ExcelWorksheet workSheet)
        {
            if (str == "big_price")
            {
                arr[0] = 2; //row1 and row2
                arr[1] = 1; //col1
                arr[2] = Convert.ToInt32(workSheet.Cells[2, 1].Text);
            }
            if (str == "base_price")
            {
                arr[0] = 2; //row1 and row2
                arr[1] = 2; //col1
                arr[2] = 5;
            }
            

        } // array_choose_if

        private void BT_base_load2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            ofd.Filter = "All file EXCEL|*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TB_base_load2.Text = ofd.SafeFileName;
                            name_way_base_price = ofd.FileName;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Close file *.xlsx! Original error: " + ex.Message);
                }
            }
           
        } // BT_base_load2_Click

        private void BT_price_load2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //ofd.Filter = "CSV files (*.csv)|*.csv| All file EXCEL|*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods; *,csv";
            ofd.Filter = "All file EXCEL|*.csv;*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods; *,csv";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TB_price_load2.Text = ofd.SafeFileName;
                            name_way_big_price = ofd.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Close file *.xlsx! Original error: " + ex.Message);
                }
            }
           
        } // BT_price_load2_Click

        private void BT_updater_Click(object sender, EventArgs e)
        {
            if (RB_big_price.Checked == true)
            {
                List <Price> arr_base_price = read_excel_file(name_way_base_price, "base_price");
                update_price_method(arr_base_price, ",00", " грн", 1, 3);
            }
            else if (RB_mini_price.Checked == true)
            {
                List<Price> arr_base_price = read_excel_file(name_way_base_price, "base_price");
                update_price_method(arr_base_price, ",00", "грн", 1, 12);
            }
            else
            {
               // List<Price> arr_base_price = read_csv_file(name_way_base_price);
                //update_price_method(arr_base_price, ",00", "", -1);

                //for (int i =01; i < arr_base_price.Count; i++)
                //{
                //    mess_text = mess_text +arr_base_price[i].name_id + " " + arr_base_price[i].price + "\t" ;
                //}
                //MessageBox.Show(mess_text);
            }
            MessageBox.Show(TB_price_load2.Text + "\n Update Success!", TB_price_load2.Text);
            TB_base_load2.Clear();
            TB_price_load2.Clear();
            BT_updater.Enabled = false;
            PB_updater.Value = 0;
            RB_big_price.Checked = false;
            RB_mini_price.Checked = false;
            RB_internet.Checked = false;
         
        } // BT_updater_Click

        private void update_price_method(List<Price> _base, string _old, string _new, int _move, int _count_max)
        {

            var package = new ExcelPackage(new FileInfo(name_way_big_price));

            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            if (_move > 0) _move = Convert.ToInt32(workSheet.Cells[2, 1].Text) - 1;
           else _move = 2;

            long _count = (workSheet.Dimension.End.Row * _count_max * _base.Count);
            long count = 0;
            
            for (int i = 1; i <= workSheet.Dimension.End.Row; i++)
            {
                count += _base.Count * _count_max;
                if (workSheet.Cells[i, 1, i, 2].Merge == true)
                {
                   continue;
                }
                for (int k = 1; k <= _count_max; k++)
                {
                     for (int j = 0; j < _base.Count; j++)
                    {
                      
                        if (workSheet.Cells[i, k].Text == _base[j].name_id)
                        {
                            
                            if (PB_updater.Value < 100) 
                                PB_updater.Value = Convert.ToInt32((count) * 100 / _count);
                            
                            _base[j].change_price_format(_old, _new);
                            
                            workSheet.Cells[i, k + _move].Value = _base[j].price;

                            if (!_base[j].name_id.StartsWith("Б-") && !_base[j].name_id.StartsWith("Кп-") && !_base[j].name_id.StartsWith("Ка-") && !_base[j].name_id.StartsWith("В-") && !_base[j].name_id.StartsWith("Абак") && !_base[j].name_id.StartsWith("Пояс"))
                                _base.RemoveAt(j);
                                                       
                            break;
                        }

                       
                    } // for j
                      
                } // for k
           } //for i
            PB_updater.Value = 100;
           
            package.Save();


        }////update_price_method

        //private List<Price> read_csv_file(string file_way)
        //{

        //    List<Price> tamp = new List<Price>();

        //    string [] str = {";"};

        //    using (StreamReader rd = new StreamReader(new FileStream(file_way, FileMode.Open)))
        //    {
                
        //        string line;
        //        while ((line = rd.ReadLine()) != null)
        //        {
        //            str = rd.ReadToEnd().Split(str, StringSplitOptions.RemoveEmptyEntries);
        //            for (int i = 0; i < str.Length; i++)
        //                tamp.Add(new Price() { name_id = str[0], price = str[2] });
        //        }
        //    }

        //    return tamp;
        //}


        private void RB_big_price_CheckedChanged(object sender, EventArgs e)
        {
            BT_updater.Enabled = true;
        }

        private void RB_mini_price_CheckedChanged(object sender, EventArgs e)
        {
            BT_updater.Enabled = true;
        }

        private void RB_internet_CheckedChanged(object sender, EventArgs e)
        {
            BT_updater.Enabled = true;
        }

        
       

        
        
    }
}
