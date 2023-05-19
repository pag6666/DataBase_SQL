using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class NewPanel
    {
        public  Panel pn;
        public Panel lo;
        public NewPanel(Panel pn) 
        {
            
            this.pn = pn;
        }
        public Panel seting(Panel pnse) 
        {
            lo.Name = "Panel";
            lo.Size = pnse.Size;
            lo.BackColor = Color.Chocolate;
            lo.Location = new Point(pnse.Location.X, pnse.Location.Y + 70);
            pn.Controls.Add(pn);
            return lo;
        }
    }
}
