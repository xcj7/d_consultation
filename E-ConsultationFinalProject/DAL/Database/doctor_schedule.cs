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
    
    public partial class doctor_schedule
    {
        public doctor_schedule()
        {
            this.doc_appoinment = new HashSet<doc_appoinment>();
        }
    
        public int schedule_id { get; set; }
        public Nullable<System.DateTime> schedule_day { get; set; }
        public Nullable<System.TimeSpan> schedule_starting_time { get; set; }
        public Nullable<System.TimeSpan> schedule_ending_time { get; set; }
        public Nullable<int> did { get; set; }
        public Nullable<int> isdeleted { get; set; }
    
        public virtual ICollection<doc_appoinment> doc_appoinment { get; set; }
        public virtual doctor_info doctor_info { get; set; }
    }
}
