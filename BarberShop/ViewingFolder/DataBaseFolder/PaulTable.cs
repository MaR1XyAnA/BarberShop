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
    
    public partial class PaulTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaulTable()
        {
            this.ClientTable = new HashSet<ClientTable>();
            this.PassportWorkerTable = new HashSet<PassportWorkerTable>();
        }
    
        public string NamePaul { get; set; }
        public int PersonalNumberPaul { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientTable> ClientTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassportWorkerTable> PassportWorkerTable { get; set; }
    }
}
