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
    
    public partial class AllowedMoves
    {
        public int Id { get; set; }
        public Nullable<int> MoveId { get; set; }
        public Nullable<int> LevelLearned { get; set; }
        public Nullable<int> PokedexId { get; set; }
    
        public virtual PokemonMoves PokemonMoves { get; set; }
        public virtual Pokedex Pokedex { get; set; }
    }
}
