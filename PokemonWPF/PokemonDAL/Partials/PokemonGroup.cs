﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDAL
{
    public partial class PokemonGroup
    {

        public override string ToString()
        {
            return Pokemon.Nickname + "\tLvl " + Pokemon.PokemonLevel;
        }
    }
}
