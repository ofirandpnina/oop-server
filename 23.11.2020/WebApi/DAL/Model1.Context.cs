﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class oopEntities : DbContext
    {
        public oopEntities()
            : base("name=oopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<classes> classes { get; set; }
        public virtual DbSet<classes_variables> classes_variables { get; set; }
        public virtual DbSet<object_value> object_value { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<userClasses_variables> userClasses_variables { get; set; }
        public virtual DbSet<userClasss> userClasss { get; set; }
        public virtual DbSet<userObject> userObject { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<valuesShape> valuesShape { get; set; }
        public virtual DbSet<variable> variable { get; set; }
    }
}
