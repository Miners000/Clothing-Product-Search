using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Search_Chapter_14
{
    public partial class Form1 : Form
    {
        ProductDBDataContext db = new ProductDBDataContext();

        public Form1()
        {
            InitializeComponent();
        }


        //Check for matching product number
        private void button1_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();

            string FindNumber = searchTextBox.Text;

            var results = from product in db.Products
                          where product.Product_Number == FindNumber
                          select product.Product_Number + ", " +
                          product.Description;

            foreach(var result in results)
            {
                productListBox.Items.Add(result);
            }
        }

        //Load the form and add all products to list box
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var product in db.Products)
            {
                productListBox.Items.Add(product.Product_Number + ", " +
                          product.Description + ", " + product.Units_On_Hand
                          + " Units on Hand, " + product.Price.ToString("c"));
            }
        }

        //Check for items with matching description
        private void descButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();

            string FindDesc = searchTextBox.Text;

            var results = from product in db.Products
                          where product.Description.Contains(FindDesc)
                          select product.Product_Number + ", " +
                          product.Description;

            foreach (var result in results)
            {
                productListBox.Items.Add(result);
            }
        }

        //Check for items within a minimum or maximum quantity
        private void minMaxUOHButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();

            double minUOH = double.Parse(minTextBox.Text);
            double maxUOH = double.Parse(maxTextBox.Text);

            if (minUOH > maxUOH)
            {
                MessageBox.Show("The minimum is higher than the maximum.");
            }

            if (minUOH < 0 || maxUOH < 0)
            {
                MessageBox.Show("Cannot have a negative quantity.");
            }

            var results = from product in db.Products
                          where product.Units_On_Hand >= minUOH && 
                          product.Units_On_Hand <= maxUOH
                          orderby product.Units_On_Hand
                          select product.Product_Number + ", " +
                          product.Description + ", " + product.Units_On_Hand +
                          " Units on Hand";

            foreach (var result in results)
            {
                productListBox.Items.Add(result);
            }
        }

        //Exit program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
