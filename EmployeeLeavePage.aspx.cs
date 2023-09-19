using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;

namespace LeaveManagementSystem
{
    public partial class EmployeeLeavePage : System.Web.UI.Page
    {
        //global variables
        string username = "";
        string password = "";
        string startDate = "";
        string endDate = "";
        string reason = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            username = Session["username"].ToString();
            password = Session["password"].ToString();
        }

        
        //method to enter leave data
        public void EnterLeaveData()
        {
            string emplName = "";
            string empPassword = "";
            object id = 0;

            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            startDate = Request.Form["startDate"];
            endDate = Request.Form["endDate"];
            reason = Request.Form["reason"];

            SqlCommand command1 = new SqlCommand("SELECT * FROM Employee WHERE userPassword='" + password + "' AND username= '" + username + "' ", conn);

            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                emplName = reader1["username"].ToString();
                empPassword = reader1["userPassword"].ToString();
                id = reader1["ID"];
            }
            conn.Close();

            if (username == emplName && password == empPassword)
            {
                conn.Open();
                
                SqlCommand cmdupdate = new SqlCommand("Update Employee SET username = '" + username + "', userPassword = '" + password + "', startDate = '" + startDate + "', endDate = '" + endDate + "', reason = '" + reason + "' WHERE ID = " + id + "", conn);
                cmdupdate.CommandType = CommandType.Text;
                cmdupdate.ExecuteNonQuery();

                conn.Close();

                label1.Text = "Data Entry Complete!";
            }
            else if (username != emplName && password != empPassword)
            {
                label2.Text = "Incorrect Input";
            }   
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            EnterLeaveData();
        }
    }
}