using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWayTest.WinFormApp
{
    public partial class BusyForm : Form
    {
        public BusyForm()
        {
            InitializeComponent();
        }

        private void BusyForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

    }
}
