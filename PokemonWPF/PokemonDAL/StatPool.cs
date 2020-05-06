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
    using System.Runtime.CompilerServices;

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
        public virtual StatCollection BaseStats { get; set; }
        public virtual StatCollection EvYield { get; set; }
        public virtual StatCollection EvStats { get; set; }
        public virtual StatCollection IvStats { get; set; }

        public int CurrentHealth(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.HP + 2 * BaseStats.HP + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.HP))) / 4) + 100) ) * (int)currentPokemon.PokemonLevel/ 100) + (int)currentPokemon.PokemonLevel + 10);

        }

        public int TotalAttack(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.Attack + 2 * BaseStats.Attack + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.Attack))) / 4) + 100)) * (int)currentPokemon.PokemonLevel / 100) + 10);

        }
        public int TotalDefense(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.Defense + 2 * BaseStats.Defense + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.Defense))) / 4) + 100)) * (int)currentPokemon.PokemonLevel / 100) + 10);
        }
        public int TotalSpAttack(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.SpecialAttack + 2 * BaseStats.SpecialAttack + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.SpecialAttack))) / 4) + 100)) * (int)currentPokemon.PokemonLevel / 100) + 10);

        }
        public int TotalSpDefense(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.SpecialDefence + 2 * BaseStats.SpecialDefence + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.SpecialDefence))) / 4) + 100)) * (int)currentPokemon.PokemonLevel / 100) + 10);
        }
        public int TotalSpeed(Pokemon currentPokemon)
        {
            return Convert.ToInt32((((IvStats.Speed + 2 * BaseStats.Speed + (Math.Abs(Math.Sqrt(Convert.ToDouble(EvStats.Speed))) / 4) + 100)) * (int)currentPokemon.PokemonLevel / 100) + 10);
        }
    }
}
