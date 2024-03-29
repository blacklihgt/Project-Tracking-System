﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private customerwebservice.PTSCustomerWebService service;
    protected void Page_Load(object sender, EventArgs e)
    {
        service = new customerwebservice.PTSCustomerWebService();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int id = service.Authenticate(txtUsername.Text, txtPassword.Text);
        if (id > 0)
        {
            Session["id"] = id;
            Response.Redirect("ProjectDetails.aspx");
        }
        else
        {
            lblMessage.Text = "incorrect login details, please try again";
        }
    }
}