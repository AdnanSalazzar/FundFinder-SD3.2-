//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer2
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobRequirementTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobRequirementTable()
        {
            this.JobRequirementDetailTables = new HashSet<JobRequirementDetailTable>();
        }
    
        public int JobRequirementID { get; set; }
        public string JobRequirementTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequirementDetailTable> JobRequirementDetailTables { get; set; }
    }
}
