using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace İmageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            // Amblemi Göster Butonu
            pictureBox1.Image = ımageList1.Images[0];
            pictureBox2.Image = ımageList1.Images[1];
            pictureBox3.Image = ımageList1.Images[2];

         
        }

    
    }
}
