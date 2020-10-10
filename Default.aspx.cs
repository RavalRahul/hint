using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    MySqlConnection con;
    MySqlCommand cmd;

    void mycon()
    {
        con = new MySqlConnection("server=localhost;user id=root;database=demo");
        con.Open();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new MySqlCommand("insert into employee values(NULL, @emp_name, @emp_post, @emp_salary)",con);
        cmd.Parameters.AddWithValue("@emp_name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@emp_post", TextBox2.Text);
        cmd.Parameters.AddWithValue("@emp_salary", TextBox3.Text);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}