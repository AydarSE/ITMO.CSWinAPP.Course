using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFLab1._2
{
    public partial class nForm : WFLab1._2.Form1
    {
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {
            Application.Run(new nForm());
        }
    }
}
