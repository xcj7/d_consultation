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
    
    public partial class user
    {
        public user()
        {
            this.bans = new HashSet<ban>();
            this.doctor_info = new HashSet<doctor_info>();
        }
    
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_password { get; set; }
        public string u_username { get; set; }
        public string u_address { get; set; }
        public Nullable<int> u_phone { get; set; }
        public string u_email { get; set; }
        public Nullable<int> u_nid { get; set; }
        public string u_category { get; set; }
        public string u_status { get; set; }
    
        public virtual ICollection<ban> bans { get; set; }
        public virtual ICollection<doctor_info> doctor_info { get; set; }
    }
}