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
    
    public partial class technologiesdeveloper
    {
        public int id_technologies_dev { get; set; }
        public int Technologies_idTechnologies { get; set; }
        public int Developer_idDeveloper { get; set; }
        public Nullable<System.DateTime> experience_from { get; set; }
        public Nullable<int> skill_level { get; set; }
        public Nullable<short> is_tech_promotor { get; set; }
        public Nullable<short> technology_promotor_approved { get; set; }
    
        public virtual developer developer { get; set; }
        public virtual technologies technologies { get; set; }
    }
}
