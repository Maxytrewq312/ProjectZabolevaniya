//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectZabolevaniya
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Monitoring = new HashSet<Monitoring>();
            this.Status = new HashSet<Status>();
        }
    
        public int IdEmp { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birth { get; set; }
        public string Gender { get; set; }
        public string Place { get; set; }
        public int IdPos { get; set; }
    
        public virtual Position Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Monitoring> Monitoring { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }
    }
}