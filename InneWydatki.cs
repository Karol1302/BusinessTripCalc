//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DelegacjeProjekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class InneWydatki
    {
        public int Id { get; set; }
        public int IdRozliczenia { get; set; }
        public string Opis { get; set; }
        public byte IlośćDokumentów { get; set; }
        public decimal Kwota { get; set; }
    
        public virtual Koszty Koszty { get; set; }
    }
}
