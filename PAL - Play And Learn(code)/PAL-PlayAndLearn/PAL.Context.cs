﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAL_PlayAndLearn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PALEntities : DbContext
    {
        public PALEntities()
            : base("name=PALEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TestQuestion> TestQuestions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestsSubjectsName> TestsSubjectsNames { get; set; }
        public virtual DbSet<UserGameInformation> UserGameInformations { get; set; }
        public virtual DbSet<UserPersonalInformation> UserPersonalInformations { get; set; }
        public virtual DbSet<UserRegistration> UserRegistrations { get; set; }
    }
}
