using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Equipment.Model.Base;

public abstract class Weapon
{
    private double damage;
    private double accuracy;
    bool aim = false;
    bool silencer = false;

    public virtual double Damage
    {
        get; set;

    }
    public virtual double Accuracy
    {
        get; set;
    }
    public virtual bool Aim
    {
        get; set;
    }
    public virtual bool Silencer
    {
        get; set;
    }
}
