//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoaDonApp_WPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public string Id { get; set; }
        public string NameProduct { get; set; }
        public string IdSupplier { get; set; }
        public string UoM { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual UoM UoM1 { get; set; }
    }
}
