using EshopBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Data
{
    public class EshopContext : DbContext
    {
        public EshopContext(DbContextOptions<EshopContext> options) : base(options)
        {

        }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<GroupToBook> GroupToBooks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupToBook>()
                .HasOne(bg => bg.Books)
                .WithMany(b => b.GroupToBooks)
                .HasForeignKey(k => k.BookId);
            modelBuilder.Entity<GroupToBook>()
                .HasOne(bg => bg.Group)
                .WithMany(b => b.GroupToBooks)
                .HasForeignKey(f => f.GroupId);


            // تعریف مقادیر اولیه برای تست
            #region Data Seed
            modelBuilder.Entity<Group>().HasData(new Group()
            {
                GroupId = 1,
                GroupName = "Roman",
                GroupDescription = "یکی از پرطرفدارترین انواع کتاب ها"
            });

            modelBuilder.Entity<Books>().HasData(new Books()
            {
                BookId = 1,
                BookAuthor = "یثربی",
                BookName = "داستان پستچی",
                BookPrice = 10000,
                BookRelease = new DateTime(2020, 04, 08),
                BookShabak = "458-3-45-45879-1",
                BookView = 0,
                PublisherId = 1
            });

            modelBuilder.Entity<GroupToBook>().HasData(new GroupToBook()
            {
                Id = 1,
                BookId = 1,
                GroupId = 1
            });

            modelBuilder.Entity<Publisher>().HasData(new Publisher()
            {
                PublisherId = 1,
                PubisherName = "باران",
                PubisherDescription = "ناشر کتاب های رمان",
                PublisherEstablished = new DateTime(2004,07,01)
            });

            // Seri2
            modelBuilder.Entity<Group>().HasData(new Group()
            {
                GroupId = 2,
                GroupName = "شعر",
                GroupDescription = "اشعار یکی از مفهومی ترین نوع نوشته ها هستند"
            });

            modelBuilder.Entity<Books>().HasData(new Books()
            {
                BookId = 2,
                BookAuthor = "نظری",
                BookName = "ضد",
                BookPrice = 15000,
                BookRelease = new DateTime(2019, 07, 08),
                BookShabak = "458-3-47-41234-9",
                BookView = 0,
                PublisherId = 2
            });

            modelBuilder.Entity<GroupToBook>().HasData(new GroupToBook()
            {
                Id = 2,
                BookId = 2,
                GroupId = 2
            });

            modelBuilder.Entity<Publisher>().HasData(new Publisher()
            {
                PublisherId = 2,
                PubisherName = "هما",
                PubisherDescription = "ناشر کتاب های شعر",
                PublisherEstablished = new DateTime(2000, 07, 01)
            });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }


}
