//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Toci.Mvcexample.Models.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class positions
    {
        [Key]
        public int id_positions { get; set; }
        public string pos_name { get; set; }
    }
}
