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
    
    public partial class hopdonglaodong
    {
        public string ma { get; set; }
        public string nhanvienma { get; set; }
        public Nullable<System.DateTime> ngaybatdau { get; set; }
        public Nullable<System.DateTime> ngayketthuc { get; set; }
    
        public virtual nhanvien nhanvien { get; set; }
    }
}
