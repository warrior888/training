﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Mvcexample.Models.DBContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeamLeasingDBContext : DbContext
    {
        public TeamLeasingDBContext()
            : base("name=TeamLeasingDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accbankaccounts> accbankaccounts { get; set; }
        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<accountadresses> accountadresses { get; set; }
        public virtual DbSet<accpayments> accpayments { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<clientsearch> clientsearch { get; set; }
        public virtual DbSet<contact> contact { get; set; }
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<courses> courses { get; set; }
        public virtual DbSet<coursesgroups> coursesgroups { get; set; }
        public virtual DbSet<devavailabilitydetailed> devavailabilitydetailed { get; set; }
        public virtual DbSet<developer> developer { get; set; }
        public virtual DbSet<dictionary> dictionary { get; set; }
        public virtual DbSet<groupscodenames> groupscodenames { get; set; }
        public virtual DbSet<lessons> lessons { get; set; }
        public virtual DbSet<lessonsdetails> lessonsdetails { get; set; }
        public virtual DbSet<phrasetechnology> phrasetechnology { get; set; }
        public virtual DbSet<positions> positions { get; set; }
        public virtual DbSet<post> post { get; set; }
        public virtual DbSet<post_course> post_course { get; set; }
        public virtual DbSet<post_tags> post_tags { get; set; }
        public virtual DbSet<project> project { get; set; }
        public virtual DbSet<projectdata> projectdata { get; set; }
        public virtual DbSet<projectdeveloper> projectdeveloper { get; set; }
        public virtual DbSet<projectstage> projectstage { get; set; }
        public virtual DbSet<projecttechnologies> projecttechnologies { get; set; }
        public virtual DbSet<projecttype> projecttype { get; set; }
        public virtual DbSet<promotorcourses> promotorcourses { get; set; }
        public virtual DbSet<recruitmenttest> recruitmenttest { get; set; }
        public virtual DbSet<stages> stages { get; set; }
        public virtual DbSet<stageteam> stageteam { get; set; }
        public virtual DbSet<studygroups> studygroups { get; set; }
        public virtual DbSet<tags> tags { get; set; }
        public virtual DbSet<technologies> technologies { get; set; }
        public virtual DbSet<technologiesdeveloper> technologiesdeveloper { get; set; }
        public virtual DbSet<technologypromotor> technologypromotor { get; set; }
    }
}
