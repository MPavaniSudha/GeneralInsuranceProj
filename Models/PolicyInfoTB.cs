//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneralInsurancePrj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PolicyInfoTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolicyInfoTB()
        {
            this.ClaimInfoes = new HashSet<ClaimInfo>();
        }
    
        public Nullable<int> Insurance_id { get; set; }
        public Nullable<int> Vehicle_id { get; set; }
        public int Policy_Number { get; set; }
        public Nullable<float> Policy_Amount { get; set; }
        public Nullable<System.DateTime> Policy_IssuredDate { get; set; }
        public Nullable<System.DateTime> Policy_ExpiryDate { get; set; }
        public string Policy_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimInfo> ClaimInfoes { get; set; }
        public virtual InsurancePlanInfo InsurancePlanInfo { get; set; }
        public virtual VehicleInsuranceInfo VehicleInsuranceInfo { get; set; }
    }
}
