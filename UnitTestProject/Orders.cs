//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string colb_upc { get; set; }
        public Nullable<int> id_service { get; set; }
        public Nullable<int> id_laborant { get; set; }
        public Nullable<System.DateTime> finish_at { get; set; }
    
        public virtual Laborants Laborants { get; set; }
        public virtual Services Services { get; set; }
    }
}
