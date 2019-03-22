using UnityEngine;
using TVSBuGGG;
public class UIInGame : MonoBehaviour, IThemeUIButton
{
    public void ButtonAttackAble ()
    {
        Controller.Instance.execute(TypeActionTeng.Attack);
        Debug.Log("Attack");
    }

    public void ButtonDefence()
    {
        Controller.Instance.execute(TypeActionTeng.Defence);
        Debug.Log("Def");
    }

    public void ButtonHeal()
    {
        Controller.Instance.execute(TypeActionTeng.Heal);
        Debug.Log("Heal");
    }

}


