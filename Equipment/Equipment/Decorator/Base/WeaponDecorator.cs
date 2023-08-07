namespace Equipment.Decorator.Base;
using Equipment.Model.Base;
public abstract class WeaponDecorator : Weapon
{
    protected Weapon modification;

    protected double damage;
    protected double accuracy;
    protected bool aim = false;
    protected bool silencer = false;
    public override double Accuracy => modification.Accuracy + accuracy;
    public override double Damage => modification.Damage + damage;

    public override bool Aim => modification.Aim;
    public override bool Silencer => modification.Silencer;

    public WeaponDecorator(Weapon modification) => this.modification = modification;
}

