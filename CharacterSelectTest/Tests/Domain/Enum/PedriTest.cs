using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character;

[TestClass]
public class PedriTest
{
    [TestMethod]
    public void TestPedriCreation()
    {
        var pedri = new Pedri("Pedri");

        Assert.IsNotNull(pedri);
    }

    [TestMethod]
    public void TestPedriStats()
    {
        var pedri = new Pedri("Pedri");

        Assert.AreEqual(105, pedri.Health);
        Assert.AreEqual(85, pedri.Strength);
        Assert.AreEqual(96, pedri.Intelligence);
        Assert.AreEqual(80, pedri.Agility);
    }

    [TestMethod]
    public void TestPedriAttack()
    {
        var pedri = new Pedri("Pedri");

        Assert.AreEqual(192, pedri.Attack());
    }

    [TestMethod]
    public void TestPedriSpecialAbility()
    {
        var pedri = new Pedri("Pedri");

        Assert.AreEqual("Perfect Pass", pedri.SpecialAbility());
    }
}