﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dpconsultationEntities : DbContext
    {
        public dpconsultationEntities()
            : base("name=dpconsultationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ban> bans { get; set; }
        public DbSet<doctor_info> doctor_info { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<doc_appoinment> doc_appoinment { get; set; }
        public DbSet<doctor_schedule> doctor_schedule { get; set; }
        public DbSet<patient> patients { get; set; }
        public DbSet<prescription> prescriptions { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
