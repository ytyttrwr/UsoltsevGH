//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OxtaPark.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orderr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orderr()
        {
            this.OrderService = new HashSet<OrderService>();
        }
    
        public int id_Order { get; set; }
        public Nullable<int> CodeOrder { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.TimeSpan> Timecreate { get; set; }
        public Nullable<int> CodeClient { get; set; }
        public Nullable<int> id_Status { get; set; }
        public Nullable<System.DateTime> DateClose { get; set; }
        public Nullable<System.TimeSpan> RentalTime { get; set; }
    
        public virtual StatusOrder StatusOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderService> OrderService { get; set; }
    }
}
