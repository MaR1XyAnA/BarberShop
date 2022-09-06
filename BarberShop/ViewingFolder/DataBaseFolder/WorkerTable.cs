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
    
    public partial class WorkerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkerTable()
        {
            this.ResultTable = new HashSet<ResultTable>();
        }
    
        public int PersonalNumberWorker { get; set; }
        public string PSWorker { get; set; }
        public string PNWorker { get; set; }
        public string StatusWorker { get; set; }
        public string PostWorker { get; set; }
        public string CardNumberWorker { get; set; }
        public string LoginWorker { get; set; }
        public string PasswordWorker { get; set; }
        public string NumberPhoneWorker { get; set; }
        public string EmailWorker { get; set; }
    
        public virtual PassportWorkerTable PassportWorkerTable { get; set; }
        public virtual PostTable PostTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultTable> ResultTable { get; set; }
        public virtual SalaryCardTable SalaryCardTable { get; set; }
        public virtual StatusTable StatusTable { get; set; }
    }
}
