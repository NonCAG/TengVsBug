using System;
using System.Collections;
using UnityEngine;
using TVSBuGGG;

public class ActionManager 
{
    ITakeDamage _take;
    IExpTable _expTable;
    ITakeHeal _heal;    
    IDefense _def;
    Player _player;
    Bug _enemy;

    public ActionManager(){
        _take = new AttackAble();
        _expTable = new ExpTable();
        _heal = new PlayerHeal();
        _def = new PlayerDefense();
        _enemy = new Bug();
        _player = new Player();
    }

    public void ExpTalet() {
        _expTable.Exp(_player, _enemy.statusbug);
    }


    public void AttackAble(bool isbool)
    {
        if (isbool)
        { // player attack
            _take.TakeDamage(_enemy.statusbug, _player.statusplayer);
            if (_enemy.statusbug.hp <= 0)
            {
                ExpTalet();
                NewEnemy();
            }
        }
        else
        { //Bug attack
            _take.TakeDamage(_player.statusplayer, _enemy.statusbug);
        }
    }

    public void PlayerHeal(float amout)
    {
        _heal.TakeHeal(_player.statusplayer, amout);
    }

    public void PlayerDefDamage()
    {
        _def.Def(_player.statusplayer,_enemy.statusbug);
    }

    public void NewEnemy() {
        System.Random random = new System.Random();
        _enemy.statusbug.atk = random.Next(20, 60);
        _enemy.statusbug.hp = random.Next(200, 500);
        _enemy.statusbug.def = random.Next(10, 50);
        _enemy.statusbug.exp = random.Next(50, 100);
        _enemy.statusbug.name = "Bug";
        Debug.Log("New Bug"+ "Atk = "+_enemy.statusbug.atk+
            "Hp = "+ _enemy.statusbug.hp + 
            "Def = " + _enemy.statusbug.def + 
            "Exp = " + _enemy.statusbug.exp);
    }
}

