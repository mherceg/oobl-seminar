//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracktor.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Info : Content
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Info()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public System.Data.Entity.Spatial.DbGeography location { get; set; }
        public double range { get; set; }
        public System.DateTime endTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Category Category { get; set; }
    }
}
