﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepnina_updater
{
    class Price
    {
        public string name_id { get; set; }
        public string price { get; set; }  

        //public Price()
        //{

        //}
 
        public void change_price_format(string a, string b)
        {
            this.price = this.price.Replace(a, b);
        }

        public void change_price_format_space()
        {
            string[] arr = this.price.Split();
            this.price = "";
            for (int i = 0; i < arr.Length; i++)
            {
                this.price += arr[i];
            }
        }             


    }
}
