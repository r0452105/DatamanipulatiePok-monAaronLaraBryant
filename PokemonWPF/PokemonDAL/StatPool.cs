//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatPool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatPool()
        {
            this.Pokemon = new HashSet<Pokemon>();
        }
    
        public int Id { get; set; }
        public Nullable<int> BaseStatId { get; set; }
        public Nullable<int> EVStatId { get; set; }
        public Nullable<int> IVStatId { get; set; }
        public Nullable<int> EffortValueYield { get; set; }
        public string Nature { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pokemon> Pokemon { get; set; }
        public virtual StatCollection StatCollection { get; set; }
        public virtual StatCollection StatCollection1 { get; set; }
        public virtual StatCollection StatCollection2 { get; set; }
        public virtual StatCollection StatCollection3 { get; set; }
    }
}
