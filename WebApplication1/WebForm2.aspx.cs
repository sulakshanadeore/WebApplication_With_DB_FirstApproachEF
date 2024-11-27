using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        northwindEntities context = new northwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
               
                List<Category> categories = context.Categories.ToList();
                GridView1.DataSource = categories;
                GridView1.DataBind();
            }

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtcatname.Text.Trim();
            category.Description=txtdesc.Text.Trim();
            context.Categories.Add(category);
            context.SaveChanges();
            Page_Load(sender, e);   
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            CategoryUtility categoryUtility = new CategoryUtility();
            Category    category = new Category();
            try
            {
             category.CategoryID = Convert.ToInt32(txtcatid.Text);
            category.CategoryName = txtcatname.Text;
            category.Description = txtdesc.Text;    
            categoryUtility.UpdateCategory(category);
            Page_Load(sender, e);
            }
            catch (CategoryNotFoundException ex)
            {

                Response.Write(ex.Message);
            }

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtcatid.Text);
                CategoryUtility categoryUtility = new CategoryUtility();
                categoryUtility.DeleteCategory(id);
                Page_Load(sender,e);
            }
            catch (CategoryNotFoundException ex)
            {

                Response.Write(ex.Message);
            }
            

        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtcatid.Text);
                CategoryUtility categoryUtility = new CategoryUtility();
                Category c=categoryUtility.FindCategory(id);
                txtcatid.Text = c.CategoryID.ToString();
                txtcatname.Text = c.CategoryName;
                txtdesc.Text = c.Description;
            }
            catch (CategoryNotFoundException ex)
            {

                Response.Write(ex.Message);
            }

        }
    }
}