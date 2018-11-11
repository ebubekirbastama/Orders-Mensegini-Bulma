using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ürün_Mensegini_Bulma.svr;


namespace Ürün_Mensegini_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AndroidSoapClient client = new AndroidSoapClient();
        private void buttonX1_Click(object sender, EventArgs e)
        {
            var sss = client.SearchByGTIN("GepirMobile", "g!2*14Cm%s", "", "", textBoxX1.Text);
            for (int i = 0; i < sss.Count; i++)
            {
               richTextBox1.Text = sss[i]; 
            }
           

        }
    }
}
