public enum TypeActionTeng
{
    Attack = 1, Defence = 2, Heal = 3
}

namespace TVSBuGGG
{
    //start class
    public class Controller : IController
    {
        #region Singleton
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }
        #endregion
        ActionManager actions = new ActionManager();
        public void execute(TypeActionTeng typeAction)
        {
            switch (typeAction)
            {
                case TypeActionTeng.Attack:
                    ActionAttack(typeAction);
                    break;
                case TypeActionTeng.Defence:
                    ActionHeal(typeAction);
                    break;
                case TypeActionTeng.Heal:
                    ActionDefence(typeAction);
                    break;
                
            }
        }

        private void ActionAttack(TypeActionTeng typeAction)
        {
            if (typeAction == TypeActionTeng.Attack)
            {
                actions.AttackAble(true);
                actions.AttackAble(false);
            }
        }
        private void ActionHeal(TypeActionTeng typeAction)
        {
            if (typeAction == TypeActionTeng.Heal)
            {
                actions.PlayerHeal(50);
            }
        }
        private void ActionDefence(TypeActionTeng typeAction)
        {
            if (typeAction == TypeActionTeng.Defence)
            {
                actions.PlayerDefDamage();
            }
        }
    }
}
