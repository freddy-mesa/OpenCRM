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
    
    public partial class Leads
    {
        public int LeadId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string OtherPhoneMobile { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> Employees { get; set; }
        public string Description { get; set; }
        public Nullable<int> LeadSourceId { get; set; }
        public Nullable<int> RatingId { get; set; }
        public Nullable<int> CampaignId { get; set; }
        public Nullable<int> IndustryId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> HiddenLead { get; set; }
        public Nullable<System.DateTime> ViewDate { get; set; }
        public Nullable<int> LeadStatusId { get; set; }
        public Nullable<bool> Converted { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual Lead_Source Lead_Source { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual Lead_Status Lead_Status { get; set; }
    }
}
