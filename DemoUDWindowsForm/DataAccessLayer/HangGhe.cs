//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoUDWindowsForm.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangGhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangGhe()
        {
            this.Ghes = new HashSet<Ghe>();
        }
    
        public int MaHangGhe { get; set; }
        public string TenHangNghe { get; set; }
        public Nullable<double> GiaVe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ghe> Ghes { get; set; }
    }
}
