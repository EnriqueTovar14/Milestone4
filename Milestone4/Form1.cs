using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Milestone4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static InvManager myInventory = new InvManager();


        public void btn_add_Click(object sender, EventArgs e)
        {
            if (txtb_name.Text == "" || txtb_stock.Text == "" || txtb_price.Text == "" || txtb_id.Text == "" || txtb_origin.Text == "")
            {
                MessageBox.Show("Please make sure all boxes are filled.");
            }

            else
            {
                int stock = int.Parse(txtb_stock.Text);
                double price = Convert.ToDouble(txtb_price.Text);
                Product item = new Product(txtb_name.Text, stock, price, txtb_id.Text, txtb_origin.Text);
                InvManager.items.Add(item);
            }

        }
        public void btn_showItems_Click_1(object sender, EventArgs e)
        {

            //show items in data grid view in form1.cs
            this.dataGridView1.DataSource = myInventory.getItemArray();

        }
        
        public void btn_remove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < InvManager.items.Count; i++)
            {
               if(txtb_remove.Text == InvManager.items[i].prodId)
                {
                     myInventory.removeItem(InvManager.items[i]);
                }
            }
        }

        public void btn_restock_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InvManager.items.Count; i++)
            {
                if (txtb_stockId.Text == InvManager.items[i].prodId)
                {
                    int stock = int.Parse(txtb_restock.Text);
                    InvManager.items[i].stock = stock;
                }
            }
        }

        public void btn_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InvManager.items.Count; i++)
            {
                try
                {
                    if (txtb_searchName.Text == InvManager.items[i].name || txtb_searchOrigin.Text == InvManager.items[i].origin)
                    {
                        MessageBox.Show("Item exists in row: " + i + "\n\nName:" + InvManager.items[i].name + "\nStock:" + InvManager.items[i].stock +
                            "\nPrice" + InvManager.items[i].price + "\nID:" + InvManager.items[i].prodId + "\nOrigin:" + InvManager.items[i].origin);
                    }
                }
                catch
                {
                    MessageBox.Show("Item does not exist.");
                }
            }
        }

       
    }
}
