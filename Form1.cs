using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventVJ
{
    public partial class EventVJ_main : Form
    {
        public EventVJ_main()
        {
            InitializeComponent();
        }

        private void btnAddMedia_Click(object sender, EventArgs e)
        {            
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);


            cmsAdd.Show(btnSender.Left + btnSender.Width + this.Left, btnSender.Top + this.Top);
        }
        
        private void cmsAddVideo_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("test1");
        }

        private void cmsAddMediaDevice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test2");
        }

        private void cmsAddPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test3");
        }
    }
}
