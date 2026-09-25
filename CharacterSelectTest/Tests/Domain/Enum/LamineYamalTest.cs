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
        Assert.AreEqual(93, lamine.Dribbling);
        Assert.AreEqual(50, lamine.Defending);
    }

    [TestMethod]
    public void TestLamineYamalAttack()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.AreEqual(276, lamine.Attack());
    }

    [TestMethod]
    public void TestLamineYamalSpecialAbility()
    {
        var lamine = new LamineYamal("Lamine Yamal");

        Assert.AreEqual("Trivela Shot", lamine.SpecialAbility());
    }
}

