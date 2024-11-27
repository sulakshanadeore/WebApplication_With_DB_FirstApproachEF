using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class CategoryUtility
    {
        northwindEntities context = new northwindEntities();
        public Category FindCategory(int id)
        {
            Category c = null;
            c = context.Categories.Find(id);
            if (c == null)
            {

                throw new CategoryNotFoundException("Category id not found");
            }
            return c;
        }
        public void DeleteCategory(int id)
        {
            Category c = context.Categories.Find(id);
            if (c != null)
            {
                context.Categories.Remove(c);
                context.SaveChanges();
            }
            else
            {
                throw new CategoryNotFoundException("Category id doesn't exists to delete");
            }
        }


        public void UpdateCategory(Category category)
        {
            int id = Convert.ToInt32(category.CategoryID);
            Category c = context.Categories.Find(id);
            if (c != null){
                c.CategoryName = category.CategoryName;
                c.Description = category.Description;
                context.SaveChanges();
            }
            else
            {
                throw new CategoryNotFoundException("Categoryid doesnot exists....");
            }
        }
    }
}