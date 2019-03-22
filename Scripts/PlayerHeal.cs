namespace TVSBuGGG
{
    using UnityEngine;
    public class PlayerHeal : ITakeHeal
    {
        public void TakeHeal(Status target, float amout)
        {
            target.hp += Mathf.Abs(amout); 
            Debug.Log(target.hp);
        }
    }
}

