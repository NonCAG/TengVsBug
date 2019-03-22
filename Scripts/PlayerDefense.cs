using UnityEngine;
namespace TVSBuGGG
{
    public class PlayerDefense : IDefense
    {
        public void Def(Status target, Status amout)
        {
            target.hp -= (amout.atk - target.def);
            Debug.Log(target.hp);
        }
    }
}
