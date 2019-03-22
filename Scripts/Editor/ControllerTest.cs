using NUnit.Framework;
using TVSBuGGG;
public class ControllerTest 
{
    [SetUp]
    public void Setup()
    {
    }
    [TestCase(TypeActionTeng.Attack)]
    [TestCase(TypeActionTeng.Defence)]
    [TestCase(TypeActionTeng.Heal)]
    public void ActionAttack_(TypeActionTeng type) {
        
    }
}
