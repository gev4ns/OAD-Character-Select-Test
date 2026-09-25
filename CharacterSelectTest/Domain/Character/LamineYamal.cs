using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class LamineYamal : Entity.Character
{
    public LamineYamal(string name) : base(name, CharacterClass.LamineYamal)
    {
        Health = 100;
        Strength = 70;
        Intelligence = 77;
        Agility = 92;
        Dribbling = 93;
        Defending = 50;
    }

    public int Attack()
    {
        return Agility * 3;
    }

    public string SpecialAbility()
    {
        return "Trivela Shot";
    }
}