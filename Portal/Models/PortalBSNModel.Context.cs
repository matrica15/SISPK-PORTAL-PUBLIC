﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PortalBsnEntities : DbContext
    {
        public PortalBsnEntities()
            : base("name=PortalBsnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MASTER_WILAYAH> MASTER_WILAYAH { get; set; }
        public DbSet<SYS_LINK> SYS_LINK { get; set; }
        public DbSet<SYS_MENU_PORTAL> SYS_MENU_PORTAL { get; set; }
        public DbSet<VIEW_MENU_PORTAL> VIEW_MENU_PORTAL { get; set; }
        public DbSet<tabel_test> tabel_test { get; set; }
    
        public virtual int PROC_SYS_SEQUENCE_FIXER()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_SYS_SEQUENCE_FIXER");
        }
    }
}
