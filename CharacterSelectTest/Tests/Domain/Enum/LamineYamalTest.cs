using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class LamineYamalTest
{
    [TestMethod]
    public void TestLamineYamalCreation()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.IsNotNull(lamine);
    }

    [TestMethod]
    public void TestLamineYamalStats()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.AreEqual(100, lamine.Health);
        Assert.AreEqual(70, lamine.Strength);
        Assert.AreEqual(77, lamine.Intelligence);
        Assert.AreEqual(92, lamine.Agility);
    }

    [TestMethod]
    public void TestLamineYamalAttack()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.AreEqual(184, lamine.Attack());
    }

    [TestMethod]
    public void TestLamineYamalSpecialAbility()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.AreEqual("Trivela Shot", lamine.SpecialAbility());
    }
}

