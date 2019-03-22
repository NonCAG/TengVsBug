using UnityEngine;
namespace TVSBuGGG
{
    public class ExpTable : IExpTable
    {
        float _expTable = 100;
        public void Exp(Status target, Status amout)
        {
            target.exp += amout.exp;
            var levelup = target.exp / _expTable;//500/100 = 5
            for (int i = 0; i <= levelup ; i++)//5
            {
                if (target.exp >= _expTable)
                {
                    target.skill += 1;
                    target.exp -= _expTable;

                    Debug.Log(target.exp + "EXP&Skill" + target.skill);
                }
            }
        }
    }
}
