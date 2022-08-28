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
    public partial class Form1 : Form
    {

        private  int _price = 0;
        private  int _totalCost = 0;
        private int _textPrice = 0;

      Dictionary<int, string> dictionaryAccessories = new Dictionary<int, string>();



        public Form1()
        {
            InitializeComponent();

            dictionaryAccessories.Add(10399, accessories.Items[0].ToString());
            dictionaryAccessories.Add(16999, accessories.Items[1].ToString());
            dictionaryAccessories.Add(67999, accessories.Items[2].ToString());
            dictionaryAccessories.Add(4199, accessories.Items[3].ToString());
            dictionaryAccessories.Add(14599, accessories.Items[4].ToString());
            dictionaryAccessories.Add(4999, accessories.Items[5].ToString());
            dictionaryAccessories.Add(10599, accessories.Items[6].ToString());
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < accessories.Items.Count; i++)
            {
                if (accessories.SelectedIndex == i)
                {
                    listSales.Items.Add(accessories.Items[i]);
                }
            }

            _price = Convert.ToInt32(price.Text);
            _totalCost += _price;
            totalCost.Text = _totalCost.ToString();

        }

        private void accessories_SelectionChangeCommitted(object sender, EventArgs e)
        {


            foreach (var item in dictionaryAccessories)
            {
                if (accessories.SelectedItem.ToString() == item.Value)
                {
                    price.Text = item.Key.ToString();
                }
            }


        }

        private void buttonEditing_Click(object sender, EventArgs e)
        {
            InformationAccessories informationAccessories = new InformationAccessories();

            if (informationAccessories.ShowDialog() == DialogResult.OK)
            {
                accessories.Items.Add(informationAccessories.TextName);
                _textPrice = Convert.ToInt32(informationAccessories.TextPrice);
                dictionaryAccessories.Add(_textPrice, informationAccessories.TextName);
            }

        }
    }
}
