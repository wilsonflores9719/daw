//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReviewsApp.DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Criticas
    {
        public int RowId { get; set; }
        public string Comentarios { get; set; }
        public Nullable<int> Estrellas { get; set; }
        public string Autor { get; set; }
        public Nullable<int> PostId { get; set; }
    
        public virtual Posts Posts { get; set; }
    }
}
