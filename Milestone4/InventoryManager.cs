using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4
{

    public class InvManager
    {
        //product list
        public static List<Product> items { get; set; }
        //constructer
        public InvManager()
        {
            //initialize the attributes
            items = new List<Product>();

            //Test Product
            Product Orange = new Product("Orange", 1, 2, "123", "usa");
            addItem(Orange);
        }

        //make an array of the items in the managaer
        public List<Product> getItemArray()
        {
            List<Product> itemArr = new List<Product>();
            foreach (Product item in items)
            {
                Product i = item;
                itemArr.Add(i);
            }
            return itemArr;
        }

        public void addItem(Product item)
        {
            items.Add(item);
        }
        public void removeItem(Product item)
        {
            items.Remove(item);
        }
        public Product findByIdOrName(string id, string name)
        {
            Product result = null;

            for (int i = 0; i < items.Count(); i++)
            {
                //does this product have the same id as a param id?
                if (items[i].prodId == id || items[i].name == name)
                    result = items[i];
            }
            return result;
        }

        public void restockItem(Product item)
        {
            item.stock = 500;
        }
        public void displayItems(InvManager manager)
        {
            Console.WriteLine(string.Join("\n", items));
        }
    }
}

