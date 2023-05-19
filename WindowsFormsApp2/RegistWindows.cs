using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RegistWindows : Form
    {
        TextBox sd= new TextBox();
        #region load 
        enum EyePatern {Close,Open}
        EyePatern Eye;
        public RegistWindows()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eye.SizeMode = PictureBoxSizeMode.Zoom;
            eye.Image = Image.FromFile(@"open_eye.png");
            Eye= EyePatern.Close;
            //
            PASSWORD_us.Multiline = true;
            sd.PasswordChar = PASSWORD_us.PasswordChar;
            PASSWORD_us.PasswordChar = '*';
            PASSWORD_us.Size = new Size(211, 50);
            //
            LOGIN_us.MaxLength = 50;
            PASSWORD_us.MaxLength = 50;
            LOGIN_us.ScrollBars = ScrollBars.Vertical;
            PASSWORD_us.ScrollBars= ScrollBars.Vertical;
            //
            this.Icon = Icon.ExtractAssociatedIcon("database.ico");
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
           
                string login = LOGIN_us.Text;
                string password = PASSWORD_us.Text;
                if (login != null && password != null)
                {
                   
                    DB.OpenConnectDB();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string QuerySelect = $"Select [Name] , [Password] from login where [Name] = '{login}' and [Password] = '{password}' ";

                    SqlCommand command = new SqlCommand(QuerySelect, DB.GetConnect());
                    DataTable table = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show($"Не правильный (Логин) или (Пароль): Password{password}, Login{login}");
                }
            
           
        }
         sqlconnectDataBase DB = new sqlconnectDataBase();
        #region Eye_clock
        private void eye_Click(object sender, EventArgs e)
        {
            if (Eye==EyePatern.Close) 
            {
                eye.Image = Image.FromFile(@"open_eye.png");
                Eye = EyePatern.Open;
                PASSWORD_us.PasswordChar = '*';
            }
            else if(Eye==EyePatern.Open)
            {
                eye.Image = Image.FromFile(@"close_eye.png");
                Eye = EyePatern.Close;
                PASSWORD_us.PasswordChar=sd.PasswordChar;
                
            }
        }
        #endregion

        private void RegistWindows_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            st.Delt = win.close;
            DB.CloseConnectDB();
        }

        private void PASSWORD_us_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                button1_Click(sender, e);
            }
        }
    }
}
