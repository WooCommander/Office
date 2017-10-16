using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Office
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App(new EcranOut());

            app.Objects.Add(new Printer("Samsung", "M2070", 2013, "_", "Laser", 120, new DateTime(2015, 12, 10), ""));
            app.Objects.Add(new Monitor("Samsung", "SA300", 2011, "led", "zt6nhmbb600170p", 125.50, new DateTime(2016, 01, 10), ""));
            app.Objects.Add(new Printer("Cannon", "LBP-1120", 2004, "_", "Laser", 130, new DateTime(2017, 10, 10), ""));

            app.Objects.Add(new Monitor("Samsung", "943", 2009, "led", "_", 220, new DateTime(2011, 12, 10), ""));
            app.Objects.Add(new Printer("Cannon", "2900", 2006, "_", "Laser", 140, new DateTime(2017, 12, 10), ""));

            app.Objects.Add(new Monitor("Samsung", "753s", 2004, "el", "_", 170, new DateTime(2008, 12, 10), ""));
            app.Objects.Add(new Monitor("Samsung", "793df", 2004, "el", "_", 180, new DateTime(2011, 12, 10), ""));

            Computer pc = new Computer("Ягуар 2017", "a10", 2014, "qwee", 420, new DateTime(2016, 12, 10), new DateTime(2012, 12, 10), "");
            pc.ComplectList.Add(new MB("asus", "m1a", 2010, "4514sd471", 220, new DateTime(2015, 08, 10), "Office.Computer"));
            pc.ComplectList.Add(new Cpu("intel", "I5600", 2013, "4we71rre", "i5", 300, new DateTime(2014, 04, 10), "Office.Computer"));
            pc.ComplectList.Add(new Memory("samsung", "we600", 2013, "4we71rre", 3000, "ddr3", 40, new DateTime(2015, 03, 10), "Office.Computer"));
            app.Objects.Add(pc);

            Computer pc1 = new Computer("Гепард 2018", "a12", 2014, "qwee", 420, new DateTime(2016, 12, 10), new DateTime(2014, 12, 10), "");
            pc1.ComplectList.Add(new MB("asus", "A50K", 2010, "4514sd471", 220, new DateTime(2015, 08, 10), "Office.Computer"));
            pc1.ComplectList.Add(new Cpu("intel", "I7600", 2013, "4we71rre", "i7", 300, new DateTime(2014, 04, 10), "Office.Computer"));
            pc1.ComplectList.Add(new Memory("samsung", "Ae1300", 2013, "4we71rre", 3000, "ddr3", 40, new DateTime(2015, 03, 10), "Office.Computer"));

            app.Objects.Add(pc1);


            //____________________________________________________________
            // работа с файлом 
            // вывод в файл
            //app.File = new FileInOut();
            //app.File.Elements = app.Ecran.Elements;
            //app.File.Save("e:\\office.dat");

            //Загрузка из файла
            app.File = new FileInOut();
            app.File.Elements = new ListOficeObjects<OfficeElement>();
            app.File.Load("e:\\office.dat");


            //____________________________________________________________
            //Работа с экраном
            app.Ecran.Elements = app.File.Elements;

            app.Ecran.ShowSimpleBu();

            app.Ecran.ShowEndGarantiya();
            Console.WriteLine();
            app.Ecran.ShowComputersShort();

            Console.WriteLine();
            app.Ecran.ShowComputersAll();

            app.Ecran.SortByName();
            app.Ecran.ShowOfficeElementsFormat();
            //____________________________________________________________


            using (гнvar db = new BloggingContext())
            {
                
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
