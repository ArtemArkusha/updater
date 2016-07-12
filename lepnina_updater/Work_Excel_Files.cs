using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using OfficeOpenXml;
//using OfficeOpenXml.Style;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace lepnina_updater
{
    class Work_Excel_Files
    {
        OpenFileDialog ofd;
        string way_to_file;

        public event Action<int> Process_Change_method;
        public event Action Show_dialog_end;
             
        public Work_Excel_Files()
        {
            ofd = new OpenFileDialog(); 
        }
        
        public string get_way()
        {
            Stream myStream = null;
            ofd.Filter = "All file EXCEL|*.csv;*.xls;*.xlsx;*.xlsm;*.xl;*.xlsb;*.xlam;*.xltx;*.xltm;*.xlt;*.thm;*.html;*.mht;*.mhtml;*.xml;*.xla;*.xlm;*.xlw;*.odc;*.uxdc;*.ods";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                           way_to_file = ofd.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! Невозможно прочесть файл. Закройте файл EXCEL(*.xlsx)! Original error: " + ex.Message);
                }
                              
            }
             return way_to_file;
            
        } // get_way()

        public string convert_way_to_TB(string str)
        {
            string[] arr = str.Split('\\');
            str = arr[arr.Length - 1];
            return str;
        } //convert_way_to_TB()

        public List<Price> get_obj(string way, string str)
        {
            var package = new ExcelPackage(new FileInfo(way));

            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            List<Price> tamp = new List<Price>();

            int[] arr = new int[3];

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
            

            for (int i = arr[0]; i <= workSheet.Dimension.End.Row; i++)
            {
                if (workSheet.Cells[i, arr[1], i, arr[2]].Merge == true)
                {
                    continue;
                }
                if (workSheet.Cells[i, arr[1]].Text != "")
                    tamp.Add(new Price() { name_id = workSheet.Cells[i, arr[1]].Text, price = workSheet.Cells[i, arr[2]].Text });

            }

            
            return tamp;
        } // get_obj

        public void list_info(List<Price> big_price, List<Price> base_price)
        {
            string mess_text = "";
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
            if (mess_text != "") MessageBox.Show(mess_text + "\n ----------------------------------------------------------- \n ИСПРАВТЕ ИНФОРМАЦИЮ В ПРАЙСЕ И СИСТЕМЕ!!!\n -----------------------------------------------------------", "ОЧЕНЬ ВАЖНО!!!");
            else MessageBox.Show("Повторений нету, проверте следующий прайс!!!", "ОЧЕНЬ ВАЖНО!!!");

        }//list_info

        public bool on_off_button(string arg1, string arg2)
        {
            bool tamp;
            if (arg1 != "")
            {
                if (arg2 != "") tamp = true;
                else tamp = false;
            }
            else tamp = false;
            return tamp;
            
            
        }

        public void update_method(List<Price> _base, string str)
        {
            var package = new ExcelPackage(new FileInfo(str));
            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            int _move = Convert.ToInt32(workSheet.Cells[2, 1].Text) - 1;

            long _count = (workSheet.Dimension.End.Row * 12 * _base.Count);
            long count = 0;

            for (int i = 1; i <= workSheet.Dimension.End.Row; i++)
            {
                count += _base.Count * 12;
                if (workSheet.Cells[i, 1, i, 2].Merge == true)
                {
                    continue;
                }
                for (int k = 1; k <= 12; k++)
                {
                    for (int j = 0; j < _base.Count; j++)
                    {
                        if (workSheet.Cells[i, k].Text == _base[j].name_id)
                        {
                          
                            if (Process_Change_method != null)
                                Process_Change_method(Convert.ToInt32((count) * 100 / _count));

                            workSheet.Cells[i, k + _move].Value = _base[j].price;
                            break;
                        } // if
                    } // for j
                } // for k           
            } //for i
            if (Process_Change_method != null) Process_Change_method(100);
            package.Save();
            if (Show_dialog_end != null)
                Show_dialog_end();
            if (Process_Change_method != null) Process_Change_method(0);

            

        }

        public void csv_update_mathod(List<Price> _base, string str)
        {
            try
            {
                string[] internet = File.ReadAllLines(str, Encoding.Default);
                StreamWriter sw = new StreamWriter(str, false, Encoding.Unicode);
                for (int i = 0; i < internet.Length; i++)
                {
                    if (!String.IsNullOrEmpty(internet[i]))
                    {
                        internet[i] = csv_method(internet[i].Split(';'), _base);
                    }
                    sw.WriteLine(internet[i]);
                    if (Process_Change_method != null)
                        Process_Change_method(i * 100 / internet.Length);
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Process_Change_method != null) 
                Process_Change_method(100);
            if (Show_dialog_end != null)
                Show_dialog_end();
            if (Process_Change_method != null) Process_Change_method(0);
        }

        public string csv_method(string[] str, List<Price> _base)
        {
            
            for (int i = 0; i < _base.Count; i++ )
            {
                if (str[0] == _base[i].name_id)
                {
                    if (_base[i].price.Length > 3) _base[i].change_price_format_space();
                    str[2] = _base[i].price;
                    break;
                }
            }
            string strrr = String.Join("\t",str);
            return strrr;
        }

        public List <Price> format_method (List <Price> obj, string _old_end_price, string _new_end_price)
        {
            for (int i = 0; i < obj.Count; i++)
            {
                obj[i].change_price_format(_old_end_price, _new_end_price);
            }
            return obj;
        }    
    }

}
