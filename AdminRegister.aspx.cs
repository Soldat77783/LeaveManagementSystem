using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveManagementSystem
{
    public partial class AdminRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Global Variables
        object id = "";
        bool success = false;

        string username = "";
        string password = "";

        //code to enter a new employee`s username and password
        public void RegisterAdmin()
        {
            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            username = Request.Form["username"];
            password = Request.Form["password"];

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"INSERT INTO Administrator(adminName, adminPassword)VALUES('" +
                 username + "' , '" + password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            label1.Text = "Data Entry Complete!";
        }

        //methoid to log in and go to the employee leave page
        public void LogInAdmin()
        {
            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string adminName = "";
            string adminPassword = "";

            username = Request.Form["username"];
            password = Request.Form["password"];

            Session["username"] = username;
            Session["password"] = password;

            SqlCommand command = new SqlCommand("SELECT * FROM Administrator WHERE adminPassword='" + password + "' AND adminName= '" + username + "' ", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                adminName = reader["adminName"].ToString();
                adminPassword = reader["adminPassword"].ToString();
            }

            if (username == adminName && password == adminPassword)
            {
                label2.Text = "Success";
                Response.Redirect("AdminPage.aspx");
            }
            else if (username != adminName && password != adminPassword)
            {
                label2.Text = "Incorrect Input";
            }

            conn.Close();
        }

        //Register button
        protected void Button2_Click1(object sender, EventArgs e)
        {
            RegisterAdmin();
        }

        //Log In button
        protected void Button1_Click1(object sender, EventArgs e)
        {
            LogInAdmin();
        }
    }
}