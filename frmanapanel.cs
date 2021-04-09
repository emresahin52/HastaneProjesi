using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneproje
{
    public partial class frmanapanel : Form
    {
        public frmanapanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhastagirisi fr = new frmhastagirisi();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdoktorgiris fr = new frmdoktorgiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş fr = new FrmSekreterGiriş();
            fr.Show();
            this.Hide();
        }

        private void frmanapanel_Load(object sender, EventArgs e)
        {

        }
    }
}
