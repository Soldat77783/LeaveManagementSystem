using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveManagementSystem
{
    public partial class AdminPage : System.Web.UI.Page
    {
        object id = "";
        string comment = "";
        int approvedAmount = 0;
        int deniedAmount = 0;
        string leaveApproval = "";
        int lePending = 0;
        string adminName = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Ammend the data(update it)
        public void ApproveLeave()
        {
            string stringConn1 = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            id = Request.Form["ID"];
            comment = Request.Form["Comment"];

            if (dropdownlist.SelectedValue == "")
            {
                label2.Text = "Please select an option.";
            }
            else
            {
                label2.Text = "You selected: " + dropdownlist.SelectedValue;
                leaveApproval = dropdownlist.SelectedValue;
            }

            if (dropdownlist.SelectedValue == "Approved")
            {
                approvedAmount = approvedAmount + 1;
              
                SqlConnection conn1 = new SqlConnection(stringConn1);
                conn1.Open();

                SqlCommand command1 = new SqlCommand("SELECT * FROM Administrator WHERE ID= '" + id + "' ", conn1);

                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    approvedAmount = int.Parse(reader1["leaveApprovalYesAmount"].ToString());
                    approvedAmount++;

                    command1 = new SqlCommand("Update Administrator SET leaveApprovalYesAmount = '" + approvedAmount + "' WHERE ID = " + id + "", conn1);
                    command1.CommandType = CommandType.Text;
                    command1.ExecuteNonQuery();
                }
                conn1.Close();

            }
            else if (dropdownlist.SelectedValue == "Denied")
            {
                SqlConnection conn1 = new SqlConnection(stringConn1);
                conn1.Open();

                SqlCommand command1 = new SqlCommand("SELECT * FROM Administrator WHERE ID= '" + id + "' ", conn1);

                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    deniedAmount = int.Parse(reader1["leaveApprovalNoAmount"].ToString());
                    deniedAmount++;

                    command1 = new SqlCommand("Update Administrator SET leaveApprovalNoAmount = '" + deniedAmount + "' WHERE ID = " + id + "", conn1);
                    command1.CommandType = CommandType.Text;
                    command1.ExecuteNonQuery();
                }
                conn1.Close();
            }
            else if (dropdownlist.SelectedValue == "Pending")
            {
                SqlConnection conn1 = new SqlConnection(stringConn1);
                conn1.Open();

                SqlCommand command1 = new SqlCommand("SELECT * FROM Administrator WHERE ID= '" + id + "' ", conn1);

                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    lePending = int.Parse(reader1["leaveApprovalPendingAmount"].ToString());
                    lePending++;

                    command1 = new SqlCommand("Update Administrator SET leaveApprovalPendingAmount = '" + lePending + "' WHERE ID = " + id + "", conn1);
                    command1.CommandType = CommandType.Text;
                    command1.ExecuteNonQuery();
                }
                    conn1.Close();
            }

            string stringConn = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            SqlCommand cmdupdate = new SqlCommand("Update Employee SET leaveStatus = '" + leaveApproval + "' WHERE ID = '" + id + "' ", conn);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();

            conn.Close();

            //admin comment entered
            string stringConn2 = @"Data Source=DESKTOP-VC8AFTR\SQLEXPRESS;Initial Catalog=LeaveDatabase;Integrated Security=True";

            SqlConnection conn2 = new SqlConnection(stringConn2);
            conn2.Open();

            SqlCommand cmdupdate2 = new SqlCommand("Update Administrator SET leaveComment = '" + comment + "' WHERE ID = '" + id + "' ", conn2);
            cmdupdate2.CommandType = CommandType.Text;
            cmdupdate2.ExecuteNonQuery();

            conn2.Close();

            label1.Text = "Data Entry Complete!";
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            ApproveLeave();
        }
    }
}

         
        

    

      
    
