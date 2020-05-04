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
    
    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            this.PlayerInventory = new HashSet<PlayerInventory>();
            this.Pokemon = new HashSet<Pokemon>();
            this.PokemonGroup = new HashSet<PokemonGroup>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PokemonOwned { get; set; }
        public Nullable<int> Badges { get; set; }
        public System.TimeSpan TimePlayed { get; set; }
        public string TrainerName { get; set; }
        public string Game { get; set; }
        public Nullable<int> MoneyOwned { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerInventory> PlayerInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pokemon> Pokemon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PokemonGroup> PokemonGroup { get; set; }
    }
}
