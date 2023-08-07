using Equipment.Decorator.Base;
using Equipment.Model.Base;
namespace Equipment.Decorator
{
    class SilencerDecorator : WeaponDecorator
    {
        public SilencerDecorator(ref Weapon weapon) : base(weapon)
        {
            if (modification.Silencer)
            {
                this.accuracy = -10;
                this.damage = 10;
                modification.Silencer = false;
            }
            this.accuracy = 10;
            this.damage = -10;
            silencer = true;
        }
    }
}
