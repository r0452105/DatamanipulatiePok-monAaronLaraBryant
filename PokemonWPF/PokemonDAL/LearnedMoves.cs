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
    
    public partial class LearnedMoves
    {
        public int Id { get; set; }
        public Nullable<int> MoveId { get; set; }
        public Nullable<int> CurrentPP { get; set; }
        public int Position { get; set; }
        public Nullable<int> PokemonId { get; set; }
    
        public virtual PokemonMoves PokemonMoves { get; set; }
        public virtual Pokemon Pokemon { get; set; }

        
    }
}
