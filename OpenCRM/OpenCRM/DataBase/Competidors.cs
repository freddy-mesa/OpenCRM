//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Competidors
    {
        public Competidors()
        {
            this.Opportunities = new HashSet<Opportunities>();
        }
    
        public int CompetidorId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Strenght { get; set; }
        public Nullable<int> Weakness { get; set; }
    
        public virtual Industry Industry { get; set; }
        public virtual ICollection<Opportunities> Opportunities { get; set; }
        public virtual Industry Industry1 { get; set; }
    }
}
