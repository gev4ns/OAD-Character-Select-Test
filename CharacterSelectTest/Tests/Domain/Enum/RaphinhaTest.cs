using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class RaphinhaTest
{
    [TestMethod]
    public void TestRaphinhaCreation()
    {
        var raphinha = new Raphinha("Raphinha");

        Assert.IsNotNull(raphinha);
    }

    [TestMethod]
    public void TestRaphinhaStats()
    {
        var raphinha = new Raphinha("Raphinha");

        Assert.AreEqual(110, raphinha.Health);
        Assert.AreEqual(88, raphinha.Strength);
        Assert.AreEqual(85, raphinha.Intelligence);
        Assert.AreEqual(90, raphinha.Agility);
    }

    [TestMethod]
    public void TestRaphinhaAttack()
    {
        var raphinha = new Raphinha("Raphinha");

        Assert.AreEqual(176, raphinha.Attack());
    }

    [TestMethod]
    public void TestRaphinhaSpecialAbility()
    {
        var raphinha = new Raphinha("Raphinha");

        Assert.AreEqual("Power Shot", raphinha.SpecialAbility());
    }
}