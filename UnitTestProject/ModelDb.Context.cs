﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LaboratoryEntities : DbContext
    {
        public LaboratoryEntities()
            : base("name=LaboratoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administartors> Administartors { get; set; }
        public virtual DbSet<Laborants> Laborants { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<PatientsAndUsers> PatientsAndUsers { get; set; }
    }
}
