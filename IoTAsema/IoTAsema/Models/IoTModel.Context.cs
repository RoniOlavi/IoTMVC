﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTAsema.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IoTDBEntities : DbContext
    {
        public IoTDBEntities()
            : base("name=IoTDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<commands> commands { get; set; }
        public virtual DbSet<devices> devices { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<measurements> measurements { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
