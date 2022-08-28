using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject5_2
{
    public partial class InformationAccessories : Form
    {
        public InformationAccessories()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string TextName
        {
            get { return textBoxName.Text; }
        }

        public string TextPrice
        {
            get { return textBoxPrice.Text; }
        }
    }
}
