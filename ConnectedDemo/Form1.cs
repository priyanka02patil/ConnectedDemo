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
using System.Configuration;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedDemo
{
    public partial class FormConnArch : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public FormConnArch()
        {
            InitializeComponent();
            // ConfigurationManager class is used to read values from the App.config file
            // establis the connection
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select name,email,salary from employee where empid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxEmpId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        textBoxName.Text = dr["name"].ToString(); // dr["column-name"]
                        textBoxEmail.Text = dr["email"].ToString();
                        textBoxSalary.Text = dr["salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into employee values(@name,@email,@salary)";
                cmd = new SqlCommand(qry, con);// fire , con
                // assign the values to the parameters
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBoxSalary.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Employee added successfully");
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
                string qry = "update employee set name=@name,email=@email,salary=@salary where empid=@id";
                cmd = new SqlCommand(qry, con);// fire , con
                // assign the values to the parameters
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBoxSalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxEmpId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Employee updated successfully");
                    //ClearFormFields();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from employee where empid=@id";
                cmd = new SqlCommand(qry, con);// fire , con
                // assign the values to the parameters
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxEmpId.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Employee deleted successfully");
                    //ClearFormFields();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxEmpId.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxSalary.Clear();
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from employee";
                cmd = new SqlCommand(qry, con);// fire , con
                con.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr); // convert dr object in to row & col format
                dataGridViewEmp.DataSource = table;
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
    }
}
