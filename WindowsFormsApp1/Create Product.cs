using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Connection_db;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DefaultConnection _DefaultConnection;
        public Form1()
        {
           
            _DefaultConnection = new DefaultConnection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetDataWithDb();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void ProductDescriptions(object sender, EventArgs e)
        {

        }

        private void ProductQuantity(object sender, EventArgs e)
        {

        }



        private void btnCreate(object sender, EventArgs e)
        {
            try
            {
                string productName = inputproductname.Text;
                string productDescription = TxtProductDescription.Text;
                int productQuantity = int.Parse(productQuantitya.Text);
                string insertQuery = $@"INSERT INTO Product(PName, PDescription,PQuantity)
                                        values('{productName}', '{productDescription}',{productQuantity});";
                bool productInsert = _DefaultConnection.InsertData(insertQuery);
                if (productInsert)
                {
                    GetDataWithDb();
                    resetbox();
                    MessageBox.Show("Successfully inserted product", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
                else
                {
                    MessageBox.Show("Something wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void resetbox ()
        {
           inputproductname.Text=string.Empty;
             TxtProductDescription.Text=string.Empty;
             productQuantitya.Text=string.Empty;
        }

        private void GetDataWithDb()
        {
            try
            {
                string getdata = "Select * from Product";
                DataTable dt = _DefaultConnection.GetDataWithDb(getdata);
                dataviewgrid.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
