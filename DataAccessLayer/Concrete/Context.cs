﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext
    {
        //cons. metod; || override olarak da tanımlama yapabiliriz;++
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configre metodu içinde bağlantı içinde bağlantı stringi tanımlamamız gerek
            //parametremiz ise dbcontext oluşturucudur.

            //bağlanacağımız db kaynağını seçiyoruz; Connection strinngini seçiyoruz;
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J5P05SU\\SQLEXPRESS; Initial Catalog = UniSozluk; Integrated Security = True");

            //base.OnModelCreating(ModelBuilder);
        }

        //contextleri yazmaya başlıyoruz; - > <SınıfAdı> Prop ismi

        public DbSet<Entry> Entries { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EntryLike> EntryLikes { get; set; }

    }
}
