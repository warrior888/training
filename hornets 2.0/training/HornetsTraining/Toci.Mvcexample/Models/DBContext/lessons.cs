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
    
    public partial class lessons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lessons()
        {
            this.lessonsdetails = new HashSet<lessonsdetails>();
        }
    
        public int id_lessons { get; set; }
        public int courses_id_courses { get; set; }
        public int lesson_enumeration { get; set; }
        public string topic { get; set; }
        public string lesson_materials { get; set; }
    
        public virtual courses courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lessonsdetails> lessonsdetails { get; set; }
    }
}
