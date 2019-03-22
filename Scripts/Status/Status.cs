public class Status
{
    public string name;
    public float hp;
    public float def;
    public float atk;

    public float exp;
    public float level;

    public Status(string name, float lv, float hp, float atk, float def, float exp) {
        this.name = name;
        this.hp = hp;
        this.def = def;
        this.level = lv;
        this.atk = atk;
        this.exp = exp;
    }
    
}
