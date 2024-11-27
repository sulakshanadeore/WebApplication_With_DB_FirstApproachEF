using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Hello world");
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Deptno10");
                DropDownList1.Items.Add("Deptno20");
                DropDownList1.Items.Add("Deptno30");
                DropDownList1.Items.Add("Deptno40");
                DropDownList1.Items.Add("Deptno50");


            }
            else {
                // Response.Write("Welcome here for the first time");
                Response.Write("The drop down already has values");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("You selected = " + DropDownList1.SelectedValue);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("You selected " + Calendar1.SelectedDate.ToString());
        }
    }
}