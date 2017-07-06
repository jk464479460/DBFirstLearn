using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            {
                //var input = Console.ReadLine();
                //if (input == "1")DropCreateDatabaseIfModelChanges
                //{
                //    Database.SetInitializer<BloggingContext>(new System.Data.Entity.CreateDatabaseIfNotExists<BloggingContext>());
                //}
                //Database.SetInitializer<BloggingContext>(new System.Data.Entity.DropCreateDatabaseIfModelChanges<BloggingContext>());
                using (var db = new BloggingContext())
                {
                    var name = "123";

                    var blog = new Blog { Name = name };
                    db.Blogs.Add(blog);
                    db.SaveChanges();

                    var tat = new Product { Name = "a"+DateTime.Now.Second, Age = 19 };
                    db.Products.Add(tat);
                    var cate = new Category { Id=100, Name = "Jhon" };
                    db.TbClass.Add(cate);
                    db.SaveChanges();
                    // Display all Blogs from the database 
                    var query = from b in db.Blogs
                                orderby b.Name
                                select b;

                    Console.WriteLine("All blogs in the database:");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Name);
                    }

                    Console.WriteLine("Press any key to exit...");
                    // Console.ReadKey();

                }
            }
           
           
               
        }
    }
}
