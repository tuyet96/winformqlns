﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khanh.DuLieu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class btvnEntities : DbContext
    {
        public btvnEntities()
            : base("name=btvnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chucvu> chucvu { get; set; }
        public virtual DbSet<hopdonglaodong> hopdonglaodong { get; set; }
        public virtual DbSet<luong> luong { get; set; }
        public virtual DbSet<nhanvien> nhanvien { get; set; }
        public virtual DbSet<phongban> phongban { get; set; }
        public virtual DbSet<trinhdohocvan> trinhdohocvan { get; set; }
    }
}