using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Raphinha : Entity.Character
{
    public Raphinha(string name) : base(name, CharacterClass.Raphinha)
    {
        Health = 110;
        Strength = 88;
        Intelligence = 85;
        Agility = 90;
    }

    public int Attack()
    {
        return Strength * 2;
    }

    public string SpecialAbility()
    {
        return "Power Shot";
    }
}