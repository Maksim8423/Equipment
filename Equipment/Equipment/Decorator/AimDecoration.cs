namespace Equipment.Decorator;
using Equipment.Decorator.Base;
using Equipment.Model.Base;

public class AimDecorator : WeaponDecorator
{
    public AimDecorator(Weapon modification) : base(modification)
    {
        if (modification.Aim)
        {
            accuracy = -10;
        }
        accuracy = 10;
        aim = true;
    }
}

