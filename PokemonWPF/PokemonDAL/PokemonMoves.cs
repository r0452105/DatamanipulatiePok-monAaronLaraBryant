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
    
    public partial class PokemonMoves
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PokemonMoves()
        {
            this.AllowedMoves = new HashSet<AllowedMoves>();
            this.EffectBundle = new HashSet<EffectBundle>();
            this.LearnedMoves = new HashSet<LearnedMoves>();
        }
    
        public int Id { get; set; }
        public string MoveName { get; set; }
        public int MoveTypeID { get; set; }
        public Nullable<int> DamagePoints { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedMoves> AllowedMoves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EffectBundle> EffectBundle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnedMoves> LearnedMoves { get; set; }
        public virtual Types Types { get; set; }
    }
}
