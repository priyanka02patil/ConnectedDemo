using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConnectedDemo
{
    public partial class FormProduct : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FormProduct()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
        }

        private void ClearFormFields()
        {
            textBoxPrdID.Clear();
            textBoxPrdName.Clear();
            textBoxPrdPrice.Clear();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into product values(@prdname,@price)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@prdname",textBoxPrdName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(textBoxPrdPrice.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Product added successfully");
                    ClearFormFields();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select prdid,prdname,price from product where prdid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxPrdID.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        textBoxPrdName.Text= dr["prdname"].ToString(); 
                        textBoxPrdPrice.Text= dr["price"].ToString() ;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update product set prdname=@prdname,price=@price where prdid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@prdname",textBoxPrdName.Text);
                cmd.Parameters.AddWithValue("@price",Convert.ToDouble(textBoxPrdPrice.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxPrdID.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Product updated successfully");
                    ClearFormFields();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close() ;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from product where prdid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxPrdID.Text));
                con.Open() ;
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Product Deleted successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridViewProduct.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close( );
            }
        }
    }
}
