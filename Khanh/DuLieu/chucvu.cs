//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khanh.DuLieu
{
    using System;
    using System.Collections.Generic;
    
    public partial class chucvu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chucvu()
        {
            this.nhanvien = new HashSet<nhanvien>();
        }
    
        public string ma { get; set; }
        public string tenchucvu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhanvien> nhanvien { get; set; }
    }
}
