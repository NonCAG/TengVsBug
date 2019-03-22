using UnityEngine;
namespace TVSBuGGG
{
    public class AttackAble : ITakeDamage
    {
        public void TakeDamage(Status target, Status amout)
        {
            target.hp -= amout.atk;
            Debug.Log(amout.name+" Attack !! "+target.name + "Hp = "+target.hp);
        }
    }
}
