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
    
    public partial class Client
    {
        public int id_Client { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Patronyme { get; set; }
        public Nullable<int> CodeClient { get; set; }
        public string Passport { get; set; }
        public Nullable<System.DateTime> Datebirth { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
