using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace DSystem
{
    public partial class WarehouseUC : UserControl
    {
        public WarehouseUC()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "mE0UoopgWaiJTaJIysrSBRIXu7IDwok2ZAECGT6K",
            BasePath = "https://dsystem-c9b50-default-rtdb.firebaseio.com/", 
        };

        IFirebaseClient client;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void WarehouseUC_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("error!");
            }

            FirebaseResponse res = client.Get(@"Warehouse");
            Dictionary<string, Warehouse> data = JsonConvert.DeserializeObject<Dictionary<string, Warehouse>>(res.Body.ToString());
            PopulateDataGrid(data);


           // LiveCall();

           
        }

       /* async void LiveCall()
        {
            while (true)
            {
                await Task.Delay(1000);
                FirebaseResponse res = await client.GetAsync(@"Users/");
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                UpdateDataGrid();
            }
        }*/

       /* void UpdateDataGrid()
        {
            /*dataGridView1.Clear();
            dataGridView1.Text += DataGridCell.ReferenceEquals(0).Key + "--" + DataGridCell.ElememtAt(0).Value + "\n";

        }*/

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Warehouse wrh = new Warehouse()
            {
                WID = widTxt.Text,
                Name = nameTxt.Text,
                Price = priceTxt.Text,
                Amount = amountTxt.Text,
                Quantity = quantityTxt.Text,
                Category = categoryTxt.Text
            };

            var setter = client.Set("Warehouse/" + widTxt.Text, wrh);
            MessageBox.Show("Data inserted successfully");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Warehouse wrh = new Warehouse()
            {
                WID = widTxt.Text,
                Name = nameTxt.Text,
                Price = priceTxt.Text,
                Amount = amountTxt.Text,
                Quantity = quantityTxt.Text,
                Category = categoryTxt.Text
            };

            var setter = client.Update("Warehouse/" + widTxt.Text, wrh);
            MessageBox.Show("Data updated successfully");


        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var result = client.Get("Warehouse/" + widTxt.Text);
            Warehouse wrh = result.ResultAs<Warehouse>();
            nameTxt.Text = wrh.Name;
            priceTxt.Text = wrh.Price;
            amountTxt.Text = wrh.Amount;
            quantityTxt.Text = wrh.Quantity;
            categoryTxt.Text = wrh.Category;
            MessageBox.Show("Data Retrieved successfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = client.Delete("Warehouse/" + widTxt.Text);
            MessageBox.Show("Data deleted successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void PopulateDataGrid(Dictionary<string, Warehouse> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("wid", "WID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("amount", "Amount");
            dataGridView1.Columns.Add("category", "Category");

            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.Name, item.Value.Price, item.Value.Amount, item.Value.Category);
            }

        }

        private void tblBtn_Click(object sender, EventArgs e)
        {
           /* FirebaseResponse res = client.Get(@"Warehouse");
            Dictionary<string, Warehouse> data = JsonConvert.DeserializeObject<Dictionary<string, Warehouse>>(res.Body.ToString());
            PopulateDataGrid(data);*/
        }

        public void clearText()
        {
            widTxt.Text = "";
            nameTxt.Text = "";
            priceTxt.Text = "";
            amountTxt.Text = "";
            quantityTxt.Text = "";
            categoryTxt.Text = "";

            MessageBox.Show("Text Boxes Cleared!");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("error!");
            }

            FirebaseResponse res = client.Get(@"Warehouse");
            Dictionary<string, Warehouse> data = JsonConvert.DeserializeObject<Dictionary<string, Warehouse>>(res.Body.ToString());
            PopulateDataGrid(data);

            MessageBox.Show("Refreshed the table");
        }
    }
}
