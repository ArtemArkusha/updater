using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Threading;
using System.Windows.Forms;
//using System.IO;
//using OfficeOpenXml;
//using OfficeOpenXml.Style;


namespace lepnina_updater
{
    public partial class Lepnina_updater : Form
    {
        private Work_Excel_Files WEF;
        string price_way;
        string base_way;
        List<Price> tamp;

        

       

        public Lepnina_updater()
        {
           InitializeComponent();
           FormBorderStyle = FormBorderStyle.FixedDialog;
           button_Check.Enabled = false;
           BT_updater.Enabled = false;
           PB_updater.Value = 0;
           PB_updater.Maximum = 100;
           WEF = new Work_Excel_Files();
           WEF.Process_Change_method += WEF_Pr_ch_mt;
           WEF.Show_dialog_end += show_dialog;
          
        }

        public void WEF_Pr_ch_mt(int progress)
        {
            Action act = () =>
            {
                if (progress <= 100)
                    PB_updater.Value = progress;
            };
            Invoke(act);
        }
        public void show_dialog()
        {
            MessageBox.Show(TB_price_load2.Text + "\n Update Success!", TB_price_load2.Text);
            TB_price_load2.Clear();
            BT_updater.Enabled = false;
            price_way = "";
            BT_base_load2.Enabled = false;
            BT_price_load2.Enabled = true;
            RB_big_price.Enabled = true;
            RB_internet.Enabled = true;
            RB_mini_price.Enabled = true;
            BT_refresh2.Enabled = true;
        }

        private void price_load1_Click(object sender, EventArgs e)
        {
            try
            {
                
                price_way = WEF.get_way();
                TB_price_info1.Text = WEF.convert_way_to_TB(price_way);
                button_Check.Enabled = WEF.on_off_button(TB_price_info1.Text, TB_base_info1.Text);
            }
            catch (Exception ex)
            {
              // MessageBox.Show("Вы отменили операцию! " + ex.Message);
            }
            
        } // price_load1_Click

        private void base_load1_Click(object sender, EventArgs e)
        {
            try
            {
                base_way = WEF.get_way();
                TB_base_info1.Text = WEF.convert_way_to_TB(base_way);
                button_Check.Enabled = WEF.on_off_button(TB_price_info1.Text, TB_base_info1.Text);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Вы отменили операцию! " + ex.Message);
            }

        } // system_price_load1_Click

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                tamp = WEF.get_obj(base_way, "base_price");
                if (WEF.get_obj(price_way, "big_price") != null && WEF.get_obj(base_way, "base_price") != null)
                {
                    ThreadStart start = delegate
                    {
                        WEF.list_info(WEF.get_obj(price_way, "big_price"),tamp);
                    };
                    Thread thread = new Thread(start);
                    thread.Start();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Невыбраны все файли для сравнения. Original error: " + ex.Message);
            }
            TB_price_info1.Clear();
            button_Check.Enabled = false;
            price_way = "";
            BT_base_load1.Enabled = false;
           
        } // Check_Click
  //------------------------------------------------------------------------------------------------------------------------------
        private void BT_base_load2_Click(object sender, EventArgs e)
        {
            try
            {
                base_way = WEF.get_way();
                TB_base_load2.Text = WEF.convert_way_to_TB(base_way);
                if (RB_big_price.Checked || RB_mini_price.Checked || RB_internet.Checked)
                    BT_updater.Enabled = WEF.on_off_button(TB_base_load2.Text, TB_price_load2.Text);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        } // BT_base_load2_Click

        private void BT_price_load2_Click(object sender, EventArgs e)
        {
            try
            {
                price_way = WEF.get_way();
                TB_price_load2.Text = WEF.convert_way_to_TB(price_way);
                if (RB_big_price.Checked || RB_mini_price.Checked || RB_internet.Checked)
                    BT_updater.Enabled = WEF.on_off_button(TB_base_load2.Text, TB_price_load2.Text);
                
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        } // BT_price_load2_Click

        private void BT_updater_Click(object sender, EventArgs e)
        {
            BT_base_load2.Enabled = false;
            BT_price_load2.Enabled = false;
            BT_updater.Enabled = false;
            BT_refresh2.Enabled = false;
            RB_big_price.Enabled = false;
            RB_internet.Enabled = false;
            RB_mini_price.Enabled = false;

            try
            {
               
                tamp = WEF.get_obj(base_way, "base_price");
                if (RB_big_price.Checked == true || (RB_mini_price.Checked == true))
                {
                    WEF.format_method(tamp, ",00", " грн");
                    ThreadStart start = delegate
                    {
                        WEF.update_method(tamp, price_way);
                    };
                    Thread thread = new Thread(start);
                    thread.IsBackground = true;
                    thread.Start();
                }
                else 
                {
                    WEF.format_method(tamp,",00", "");
                    ThreadStart start = delegate
                    {
                       WEF.csv_update_mathod(tamp, price_way);
                    };
                    Thread thread = new Thread(start);
                    thread.IsBackground = true;
                    thread.Start();              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Невыбраны все файли для сравнения. Original error: " + ex.Message);
            }
           
           
       } // BT_updater_Click

        private void RB_big_price_CheckedChanged(object sender, EventArgs e)
        {
             BT_updater.Enabled = WEF.on_off_button(TB_base_load2.Text, TB_price_load2.Text);
        }

        private void RB_mini_price_CheckedChanged(object sender, EventArgs e)
        {
            BT_updater.Enabled = WEF.on_off_button(TB_base_load2.Text, TB_price_load2.Text);
        }

        private void RB_internet_CheckedChanged(object sender, EventArgs e)
        {
            BT_updater.Enabled = WEF.on_off_button(TB_base_load2.Text, TB_price_load2.Text); 
        }

        private void BT_refresh_Click(object sender, EventArgs e)
        {
            TB_base_info1.Clear();
            TB_price_info1.Clear();
            button_Check.Enabled = false;
            price_way = "";
            base_way = "";
            BT_base_load1.Enabled = true;
            BT_price_load1.Enabled = true;
        }
        private void BT_refresh2_Click(object sender, EventArgs e)
        {
            TB_base_load2.Clear();
            TB_price_load2.Clear();
            BT_base_load2.Enabled = true;
            BT_price_load2.Enabled = true;
            BT_updater.Enabled = false;
            price_way = "";
            base_way = "";
            GetRb_big_price.Checked = false;
            GetRb_mini_price.Checked = false;
            GetRb_internet.Checked = false;

        }
        public RadioButton GetRb_big_price
        {
            get
            {
                return RB_big_price; 
            }
        }
        public RadioButton GetRb_mini_price
        {
            get
            {
                return RB_mini_price;
            }
        }
        public RadioButton GetRb_internet
        {
            get
            {
                return RB_internet;
            }
        }

     
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 instr_fild = new Form2();
            instr_fild.Hide();
            instr_fild.Show();
        }

        private void createrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 instr_fild = new Form3();
            instr_fild.Hide();
            instr_fild.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
