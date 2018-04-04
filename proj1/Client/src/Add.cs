﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(this.textBox2.Text);
            double price = double.Parse(this.textBox1.Text);
            try
            {
                if (this.radioButton1.Checked)
                {
                    Operations.AddBuyOrder(Client.username, amount, price);
                }
                if (this.radioButton2.Checked)
                {
                    Operations.AddSellOrder(Client.username, amount, price);
                }
            }catch(Exception ex)
            {

            }
            
            this.Close();
        }
    }
}