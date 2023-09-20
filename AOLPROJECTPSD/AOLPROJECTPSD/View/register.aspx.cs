using AOLPROJECTPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AOLPROJECTPSD.View
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // kosongin semua textbox
            if (!IsPostBack)
            {
                usernameTxt.Text = "";
                admin_radiobutton.Checked = false;
                seller_radiobutton.Checked = false;
                buyer_radiobutton.Checked = false;

                female_radiobutton.Checked = false;
                male_radiobutton.Checked = false;

                emailTxt.Text = "";
                passwordTxt.Text = "";
                confirmpasswordTxt.Text = "";
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            //ambil semua data field terus controller add user 
            String Username = usernameTxt.Text;
            int Role;
            if (admin_radiobutton.Checked)
                Role = 1;
            else if (seller_radiobutton.Checked)
                Role = 2;
            else if (buyer_radiobutton.Checked)
                Role = 3;
            else
                Role = 0;
            String Gender = null;
            if (female_radiobutton.Checked)
                Gender = "Female";
            else if (male_radiobutton.Checked)
                Gender = "Male";
            String Email = emailTxt.Text;
            String Password = passwordTxt.Text;
            String ConfirmPassword = confirmpasswordTxt.Text;

            string status = userController.createUser(Username, Email, Password, Gender, Role, ConfirmPassword);
            errorLbl.Text = status;
            if (status.Equals("User Registered"))
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}