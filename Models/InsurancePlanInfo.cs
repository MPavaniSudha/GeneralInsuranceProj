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
    
    public partial class InsurancePlanInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsurancePlanInfo()
        {
            this.PolicyInfoTBs = new HashSet<PolicyInfoTB>();
        }
    
        public int Insurance_Id { get; set; }
        public string Insurance_Type { get; set; }
        public Nullable<int> Insurance_No_Of_Years { get; set; }
        public Nullable<int> Vehicle_id { get; set; }
        public Nullable<int> Regist_Id { get; set; }
    
        public virtual RegistrationInfo RegistrationInfo { get; set; }
        public virtual VehicleInsuranceInfo VehicleInsuranceInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyInfoTB> PolicyInfoTBs { get; set; }
    }
}
