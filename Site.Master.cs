using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Xml.Linq;
using System.Data;

namespace LeaveManagementSystem
{
    public partial class SiteMaster : MasterPage
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
        public void RegisterEmployee()
        {
            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";
           
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            username = Request.Form["username"];
            password = Request.Form["password"];

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"INSERT INTO Employee(username, userPassword)VALUES('" +
                 username + "' , '" + password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            label1.Text = "Data Entry Complete!";
        }

        //methoid to log in and go to the employee leave page
        public void LogInEmployee()
        {
            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";
            
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string emplName = "";
            string empPassword = "";

            username = Request.Form["username"];
            password = Request.Form["password"];

            Session["username"] = username;
            Session["password"] = password;

            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE userPassword='" + password + "' AND username= '" + username +"' " , conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                emplName = reader["username"].ToString();
                empPassword = reader["userPassword"].ToString();
            }

            if (username == emplName && password == empPassword)
            {
                label2.Text = "Success";
                Response.Redirect("EmployeeLeavePage.aspx");
            }
            else if(username != emplName && password != empPassword)
            {
                label2.Text = "Incorrect Input";
            }

            conn.Close();
        }

        //Register button
        protected void Button2_Click1(object sender, EventArgs e)
        {
            RegisterEmployee();
        }

        //Log In button
        protected void Button1_Click1(object sender, EventArgs e)
        {
            LogInEmployee();
        }

        //admin register button
        protected void Button4_Click4(object sender, EventArgs e)
        {
            Response.Redirect("AdminRegister.aspx");
        }
    }
}