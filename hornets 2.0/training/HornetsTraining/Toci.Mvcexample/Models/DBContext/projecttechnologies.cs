//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class projecttechnologies
    {
        public int id_projectTechnologies { get; set; }
        public int Technologies_idTechnologies { get; set; }
        public int Project_idProject { get; set; }
    
        public virtual project project { get; set; }
        public virtual technologies technologies { get; set; }
    }
}
