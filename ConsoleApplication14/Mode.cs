using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ConsoleApplication14
{
    //public class BloggingContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }
    //    public DbSet<Post> Posts { get; set; }
    //}
    public class BloggingContext : DbContext
    {
        public BloggingContext(): base("name=DBConnectionString") { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TAT> Tats { get; set; }
        public DbSet<AB> ABs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> TbClass { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<BloggingContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class TAT
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class AB
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Product
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
    }
    [Table("TbClass")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
