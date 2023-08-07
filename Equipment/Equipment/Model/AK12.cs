namespace Equipment.Model;
using Equipment.Decorator;
using Equipment.Model.Base;
using System;

public class AK12 : Weapon
{
    
    public AK12()
    {
        this.Damage = 86;
        this.Accuracy = 20;
    }
}
