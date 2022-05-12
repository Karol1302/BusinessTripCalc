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
    
    public partial class Koszty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Koszty()
        {
            this.InneWydatki = new HashSet<InneWydatki>();
            this.Transport = new HashSet<Transport>();
        }
    
        public int IdRozliczenia { get; set; }
        public Nullable<decimal> KosztNoclegu { get; set; }
        public Nullable<decimal> KosztWyzywienia { get; set; }
        public Nullable<decimal> KosztTransportu { get; set; }
        public Nullable<decimal> InneKoszty { get; set; }
        public Nullable<decimal> KwotaZaliczki { get; set; }
        public decimal ŁącznyKosztDelegacji { get; set; }
        public Nullable<decimal> ZwrotKosztów { get; set; }
        public Nullable<decimal> ZwrotZaliczki { get; set; }
        public Nullable<decimal> RyczałtNocleg { get; set; }
        public Nullable<decimal> Diety { get; set; }
        public Nullable<decimal> KilometrówkiSuma { get; set; }
        public int IdPracownika { get; set; }
        public int IdDelegacji { get; set; }
    
        public virtual Delegacja Delegacja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InneWydatki> InneWydatki { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transport> Transport { get; set; }
    }
}
