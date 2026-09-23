using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Pedri : Entity.Character
{
    public Pedri(string name) : base(name, CharacterClass.Pedri)
    {
        Health = 105;
        Strength = 85;
        Intelligence = 96;
        Agility = 80;
    }

    public int Attack()
    {
        return Intelligence * 2;
    }

    public string SpecialAbility()
    {
        return "Perfect Pass";
    }
}