using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Spending : Form
    {
        public Spending()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon("icon.ico");
        }
        string[] arrname;
        int[] arrprice;
        private void Spending_Load(object sender, EventArgs e)
        {
            arrname = new string[50];
            arrprice = new int[50];
            for (int i=0,j=0;i<saveFile.name.Length;i++,j++) 
            {
                if (saveFile.name[i]!=null) 
                {
                    arrname[i] =saveFile.name[i] ;
                }
                if (saveFile.price[j]!=0) 
                {
                    arrprice[j] = saveFile.price[j];
                }
            }
            //


        }
       
           
        private void information_button_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int chek = 0;
            for (int i = 0, j = 0; i < saveFile.name.Length; i++, j++)
            {
                if (arrname[i] != null)
                {
                    chek++;
                    richTextBox1.Text += $"name: {arrname[i]} ";
                }
                if (arrprice[j] != 0)
                {
                    richTextBox1.Text += $"price: {arrprice[j]}\n";
                }
                
            }richTextBox1.Text += chek;
        }

        private void Spending_Resize(object sender, EventArgs e)
        {

        }
        Point ms;
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            ms = new Point(e.X,e.Y);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) 
            {
                button2.Left += e.X - ms.X;
                button2.Top += e.Y - ms.Y;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kech=5800;
            int i=0;
            foreach (int g in arrprice) 
            {
                i += g;
            }
            textBox1.Text = $"{i}";

            textBox2.Text = $"{kech-i}";
        }
    }
}
