﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Report.Core.Context;
using Report.Core.Entity;

namespace Report.Core.Context
{
    public partial class CounterContext : BaseContext
    {
        public DbSet<Counter> Counters { get; set; } = null!;
        public CounterContext(DbContextOptions<BaseContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var username = Environment.GetEnvironmentVariable("MYSQL_USERNAME");
        //        var password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
        //        var addressParts = Environment.GetEnvironmentVariable("MYSQL_ADDRESS")?.Split(':');
        //        var host = addressParts?[0];
        //        var port = addressParts?[1];
        //        var connstr = $"server={host};port={port};user={username};password={password};database=aspnet_demo";
        //        optionsBuilder.UseMySql(connstr, Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.18-mysql"));
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            modelBuilder.Entity<Counter>().ToTable("Counters");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
