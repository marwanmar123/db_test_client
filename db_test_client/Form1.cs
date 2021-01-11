using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace db_test_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String connect = ConfigurationManager.ConnectionStrings["connSS"].ConnectionString;

        private void Client_List_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connect;

            String query = "SELECT * FROM TBL_Client";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows == true)
            {
                this.dt_gridview.Rows.Clear();
                while (read.Read())
                {
                    this.dt_gridview.Rows.Add(read[0], read[1], read[2], read[3], read[4]);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("table vide");
            }
        }


        private void btn_add_c_Click(object sender, EventArgs e)
        {
            //SELECT INTO TBL_Client VALUES(,'','','',)
            using (SqlConnection conn = new SqlConnection(connect))
            {
                if (check == true)
                    return;
                string query = "INSERT INTO TBL_Client VALUES(" + this.input_id_C.Text.Trim() + ", '" + this.input_name_c.Text.Trim().ToUpper() + "', '" + this.input_lName_c.Text.Trim()
                    .ToUpper() + "', '" + this.input_mail_c.Text.Trim() + "','" + this.input_ville_c.Text.Trim() + "');";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn.State == ConnectionState.Open)

                    conn.Close();
                conn.Open();
                int a = cmd.ExecuteNonQuery();
                Client_List_Click(sender, e);
                MessageBox.Show(a + "adding line");
                conn.Close();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Client_List_Click(sender, e);
            this.dt_gridview.ReadOnly = true;

            this.dt_gridview.AllowUserToAddRows = false;
            int incrID = this.dt_gridview.Rows.Count - 1;
            this.input_id_C.Text = (Convert.ToInt32(this.dt_gridview.Rows[incrID].Cells[0].Value.ToString()) + 1).ToString();
            this.input_id_C.Enabled = false;
        }

        int position = -1, IDC;
        bool check = false;
        private void dt_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = dt_gridview.CurrentRow.Index;
            IDC = int.Parse(this.dt_gridview.Rows[0].Cells[0].Value.ToString());
            this.input_id_C.Text = this.dt_gridview.Rows[position].Cells[0].Value.ToString();
            this.input_name_c.Text = this.dt_gridview.Rows[position].Cells[1].Value.ToString();
            this.input_lName_c.Text = this.dt_gridview.Rows[position].Cells[2].Value.ToString();
            this.input_mail_c.Text = this.dt_gridview.Rows[position].Cells[3].Value.ToString();
            this.input_ville_c.Text = this.dt_gridview.Rows[position].Cells[4].Value.ToString();

            this.input_id_C.Enabled = false;
            check = true;
        }


        private void btn_delete_c_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("select a client");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connect))
            {
                DialogResult confrm = MessageBox.Show("????", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confrm == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM TBL_Client WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", IDC);
                conn.Open();
                cmd.ExecuteNonQuery();
                this.dt_gridview.Rows.RemoveAt(position);
                MessageBox.Show("client deleted succesfuly");
                conn.Close();

            }
        }

        private void btn_new_check_Click(object sender, EventArgs e)
        {
            check = false;
            this.input_id_C.Enabled = true;
            this.input_id_C.Text = string.Empty;
            this.input_name_c.Text = string.Empty;
            this.input_lName_c.Text = string.Empty;
            this.input_mail_c.Text = string.Empty;
            this.input_ville_c.Text = string.Empty;

            int incrID = this.dt_gridview.Rows.Count - 1;
            this.input_id_C.Text = (Convert.ToInt32(this.dt_gridview.Rows[incrID].Cells[0].Value.ToString()) + 1).ToString();
            this.input_id_C.Enabled = false;
        }

        private void input_search_c(object sender, EventArgs e)
        {

        }

        private void btn_serach_c_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM TBL_Client WHERE id = @ID";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", this.input_srx_c.Text.Trim());
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    MessageBox.Show("Name is : " + rd[1] + "\nlast name is : " + rd[2] + "\nemail is : " + rd[3] + "\nville is : " + rd[4]);
                }
                else
                {
                    MessageBox.Show("the client " + this.input_srx_c.Text + " not found");
                }
                conn.Close();
            }
        }

        private void btn_edit_c_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TBL_Client SET C_name = @name, C_fname= @fname, mail = @mail, ville = @ville WHERE id = @ID";
            using (SqlConnection conn = new SqlConnection(connect))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", this.input_name_c.Text.Trim());
                cmd.Parameters.AddWithValue("@fname", this.input_lName_c.Text.Trim());
                cmd.Parameters.AddWithValue("@mail", this.input_mail_c.Text.Trim());
                cmd.Parameters.AddWithValue("@ville", this.input_ville_c.Text.Trim());
                cmd.Parameters.AddWithValue("@ID", this.input_id_C.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Client_List_Click(sender, e);
                MessageBox.Show("row id edited");
            }
        }
    }
}
