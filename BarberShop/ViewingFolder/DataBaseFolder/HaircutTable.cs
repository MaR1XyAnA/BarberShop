//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop.ViewingFolder.DataBaseFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class HaircutTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HaircutTable()
        {
            this.ResultTable = new HashSet<ResultTable>();
        }
    
        public int PersonalNumberHaircut { get; set; }
        public string NameHaircut { get; set; }
        public Nullable<System.TimeSpan> TimeHaircut { get; set; }
        public string DescriptionHaircut { get; set; }
        public decimal PriceHaircut { get; set; }
        public byte[] PhotoHaircut { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultTable> ResultTable { get; set; }
    }
}
