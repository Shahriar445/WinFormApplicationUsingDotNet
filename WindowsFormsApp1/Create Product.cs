using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Connection_db;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection  con = new SqlConnection("Data Source=DESKTOP-PM9DUD3;Initial Catalog=ProductDetails;Integrated Security=True;");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        private DefaultConnection _DefaultConnection;
        public Form1()
        {
           
            _DefaultConnection = new DefaultConnection();
            InitializeComponent();
            dataviewgrid.RowHeaderMouseDoubleClick += dataviewgrid_RowHeaderMouseDoubleClick;

        }

        int Id = 0;
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

        private void dataviewgrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataviewgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                inputproductname.Text = dataviewgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtProductDescription.Text = dataviewgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                productQuantitya.Text = dataviewgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (inputproductname.Text!="" && productQuantitya != null && TxtProductDescription.Text !="")
            {

                cmd =new SqlCommand("update Product set PName=@name, PDescription=@description, PQuantity=@quantity where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", inputproductname.Text);
                cmd.Parameters.AddWithValue("@description", TxtProductDescription.Text);
                cmd.Parameters.AddWithValue("@quantity", productQuantitya.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                GetDataWithDb();
                resetbox();
            } 
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        

        }
    }
}
