//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhoaLuanSteam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TINHTRANGDH
    {
        public TINHTRANGDH()
        {
            this.PHIEUDATHANGs = new HashSet<PHIEUDATHANG>();
        }
    
        public int TinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
    
        public virtual ICollection<PHIEUDATHANG> PHIEUDATHANGs { get; set; }
    }
}
