using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BlogCeyinSite.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> categories = new List<Category>() {
                new Category(){ CategoryName="C# Console Application"},
                new Category(){ CategoryName="ASP.NET MVC "},
                new Category(){ CategoryName="Windows Services"},
                new Category(){ CategoryName="ASP.NET N-Tier Structure"},
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>() {
                // Author="burakerdal94"
                new Blog(){ Title="C# Using With MongoDB stored Cencor Data from Arduino UNO", Description="Temperature-Humidity Cencors from Arduino UNO to SerialPort to Computer.", Image="1.jpg", Content="Cencor data transferred to mongoDB with short delay, after CencorsAPI get data to site from database. Using Glyphicons exactly visual elements on Bootstrap v3.4.1", SubmitTime=DateTime.Now.AddDays(-14), Confirm=true, PublishHome=true, CategoryId=1,Author="burakerdal94"},
                new Blog(){ Title="KeyListener usability in C# ", Description="Controlling arrow keys on Console", Image="1.jpg", Content="Cursor movement by the KeyListener actions that visible all corners and edges.Using Glyphicons exactly visual elements on Bootstrap v3.4.1. Temperature-Humidity Cencors from Arduino UNO to SerialPort to Computer.", SubmitTime=DateTime.Now.AddDays(-10), Confirm=true, PublishHome=false, CategoryId=1,Author="burakerdal94"},
                new Blog(){ Title="Geocoding with GoogleAPI", Description="Windows Service Routine with using Thread", Image="2.jpg", Content="Find Address with ReverseGeocoding by posting latitude and longtitude values to Geocoding API formatted address json or xml format. Using Glyphicons exactly visual elements on Bootstrap v3.4.1 Cursor movement by the KeyListener actions that visible all corners and edges. Temperature-Humidity Cencors from Arduino UNO to SerialPort to Computer", SubmitTime=DateTime.Now.AddDays(-12), Confirm=true, PublishHome=true, CategoryId=3,Author="burakerdal94"},
                new Blog(){ Title="Online Lectures", Description="ASP.NET Web Application with MSSQL", Image="1.jpg", Content="Students and Lecturers meet on this application, students takes courses also lecturers give courses whatever you want. Cencor data transferred to mongoDB with short delay, after CencorsAPI get data to site from database.", SubmitTime=DateTime.Now.AddDays(-16), Confirm=true, PublishHome=true, CategoryId=4,Author="aliveli"},
                new Blog(){ Title="Bootstrap Web Pages", Description="Glyphicons did not displayed", Image="1.jpg", Content="Using Glyphicons exactly visual elements on Bootstrap v3.4.1.Cursor movement by the KeyListener actions that visible all corners and edges. Find Address with ReverseGeocoding by posting latitude and longtitude values to Geocoding API formatted address json or xml format.", SubmitTime=DateTime.Now.AddDays(-13), Confirm=true, PublishHome=true, CategoryId=2,Author="burakerdal94"},
            };
            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();
            
            

            base.Seed(context);
        }
    }
}