//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObjectManagementSystem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATEGORY_TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORY_TABLE()
        {
            this.OBJECT_TABLE = new HashSet<OBJECT_TABLE>();
        }
    
        public byte ID { get; set; }
        public string NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBJECT_TABLE> OBJECT_TABLE { get; set; }
    }
}
