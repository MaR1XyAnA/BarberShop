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
    
    public partial class PostTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostTable()
        {
            this.WorkerTable = new HashSet<WorkerTable>();
        }
    
        public int PersonalNumberPost { get; set; }
        public string NamePost { get; set; }
        public string DescriptionPost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkerTable> WorkerTable { get; set; }
    }
}
