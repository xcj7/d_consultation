//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class prescription
    {
        public int pres_id { get; set; }
        public string pres_medicine { get; set; }
        public string pres_test { get; set; }
        public string pres_advice { get; set; }
        public int p_id { get; set; }
        public Nullable<int> u_id { get; set; }
    
        public virtual patient patient { get; set; }
        public virtual user user { get; set; }
    }
}
