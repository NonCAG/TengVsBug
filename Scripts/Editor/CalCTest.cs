using NUnit.Framework;
using UnityEngine;
using TVSBuGGG;

public class CalCTest
{
    Player player;
    Status statusbug;
    [SetUp]//reset new Testcase
    public void Setup()
    {
        player = new Player();
        statusbug = new Status("Enemy",20,20,20,150);
    }
    
    [Test]
    public void TakeDamage_AttackEnemy_EnemyHpLost()
    {
        AttackAble damage = new AttackAble();
        var expecthp = player.statusplayer.hp - statusbug.atk;
        damage.TakeDamage(player.statusplayer, statusbug);
        Assert.AreEqual(expecthp, player.statusplayer.hp);

    }
    
    [TestCase(10)]
    [TestCase(120)]
    [TestCase(150)]
    [TestCase(11232)]
    public void TakeHeal_UseItem_HpUp(int value)
    {
        PlayerHeal heal = new PlayerHeal();
        var expecthp = player.statusplayer.hp + value;
        heal.TakeHeal(player.statusplayer, value);
        Assert.AreEqual(expecthp, player.statusplayer.hp);
    }

    [Test]
    public void Exp_KillEnemy_ExpUp()
    {
        var table = 100;

        ExpTable expTable = new ExpTable();
        var expectskill =  Mathf.Floor(player.skill + (statusbug.exp/ table));
        var expectlevel = player.exp + statusbug.exp;
        expTable.Exp(player, statusbug);

        Assert.AreEqual(expectskill, player.skill);
        Assert.AreEqual(expectlevel, statusbug.exp);
    }

    [Test]
    public void Def_DefLessThanDamage_HpLost()
    {
        PlayerDefense defense = new PlayerDefense();
        var expecthp =  player.statusplayer.hp - (statusbug.atk - player.statusplayer.def);
        defense.Def(player.statusplayer,statusbug);

        Assert.AreEqual(expecthp, player.statusplayer.hp);
    }

    [TestCase(true)]
    [TestCase(false)]
    public void Facade(bool isattack)
    {
        ActionManager fac = new ActionManager();
        fac.AttackAble(isattack);
    }

}
