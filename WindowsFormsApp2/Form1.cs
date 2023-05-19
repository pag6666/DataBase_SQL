using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        sqlconnectDataBase DB = new sqlconnectDataBase();
        string IconPath = @"icon.ico";
        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(IconPath);
            panel2.AutoScroll = false;
            panel2.HorizontalScroll.Enabled = false;
            panel2.HorizontalScroll.Visible = false;
            panel2.HorizontalScroll.Maximum = 0;
            panel2.AutoScroll = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegistWindows rw = new RegistWindows();
            rw.ShowDialog();
            if (st.Delt == win.close)
            {
                this.Close();
            }
            DB.OpenConnectDB();  
        }
        Panel pn;
        //
        TextBox tbname= new TextBox();
        TextBox tbprice= new TextBox();
        //
        Label newName;
        Label newPrice;
        //
        Label lbprice;
        Label lbname;
       static string[] tbNameArr = new string[50];
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            lbprice = new Label();
            lbname = new Label();
            //
            newName = new Label();
            newPrice = new Label();
            //
           
            pn = new Panel();
            #region
            //new name
            newName.Size = new Size(100, 25);
            newName.Location = new Point(3,25);
            newName.ForeColor = Color.White;
            newName.Font= new Font("",18f);
            newName.Text = $"{i}";

            //new price
            newPrice.Size = new Size(100, 25);
            newPrice.Location = new Point(130, 25);
            newPrice.ForeColor = Color.White;
            newPrice.Font = new Font("", 18f);
            newPrice.TextChanged += new System.EventHandler(this.tbprice_TextChanged);
            newPrice.Text = $"{i}";
            //
            tbprice.Size = new Size(100, 25);
            tbprice.Location = new Point(130, 25);
            tbprice.Multiline = true;

            //
            lbprice.Name = "labelprice";
            lbprice.Location = new Point(130,10);
            lbprice.Size = new Size(30,13);
            lbprice.Text = "price";
            //
            lbname.Name = "labelname";
            lbname.Location = new Point(5, 10);
            lbname.Size = new Size(100,25);
            lbname.Text = "Name";
            //
            tbname.Size = new Size(100,25);
            tbname.Location = new Point(5,25);
            tbname.Multiline = true;
            //
            pn.Name = "Panel";
            pn.Size = panel1.Size;
            pn.BackColor = Color.DarkGray;
            pn.Location = new Point(panel1.Location.X, panel2.Controls[i].Location.Y + 70);
            //
            #endregion
            //


            //
            
                pn.Controls.Add(tbprice);
                pn.Controls.Add(tbname);
            
            pn.Controls.Add(newName);
            pn.Controls.Add(newPrice);
            //

            //
            pn.Controls.Add(lbprice);
            pn.Controls.Add(lbname);
            ////
            saveFile.name[i] = tbname.Text;
           bool checkint= int.TryParse(tbprice.Text, out saveFile.price[i]);
            if (!checkint)
            {
                
            }
            else 
            {
                saveFile.price[i]=Convert.ToInt32(tbprice.Text);
            }
            

            
            tbname.Text = "";
            tbprice.Text = "";
            panel2.Controls.Add(pn);
            
            
            
                pn.Controls.Add(label1);
            
           
            i++;
        }
        Point ptr;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ptr = new Point(e.X,e.Y);
            if (panel3.Width<3) 
            {
                panel3.Top=50;
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (MouseButtons.Left == e.Button){
               
                    panel3.Top += e.Y - ptr.Y;
                
                    panel3.Left += e.X - ptr.X;
                
            }
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {
          /*  if (tbname.Text!=null) 
            {
                label1_Click(sender, e);
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbprice_TextChanged(object sender, EventArgs e) 
        {
            int i = 0;
            if (int.TryParse(tbprice.Text,out i))
            {
                 errorProvider1.SetError(tbprice, "nosdst int");
            }
            else 
            {
               errorProvider1.Clear();
            }
        }
        Spending object_spending;
        private void счётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object_spending = new Spending();
            object_spending.ShowDialog();
        }
    }
    class saveFile 
    {
       public static string[] name = new string[50];
        public static int[] price = new int[50];
    }
}
