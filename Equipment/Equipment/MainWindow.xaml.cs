
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Equipment;

using Equipment.Decorator;
using Equipment.Model.Base;
using Equipment.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
       
    public MainWindow()
    {
        InitializeComponent();
        this.DamageProgressBar.Value = weapon.Damage;
        this.AccuracyProgressBar.Value = weapon.Accuracy;
    }
    Weapon weapon = new AK12();
    Weapon defaultWeapon = new AK12();
    
   

    private void SetSilencerDecorator(object sender, RoutedEventArgs e)
    {
 
        weapon = new SilencerDecorator(ref weapon);
        this.DamageProgressBar.Value = weapon.Damage;
        this.AccuracyProgressBar.Value = weapon.Accuracy;
        this.SetSilencer.IsEnabled = false;
    }
    

    private void SetAimDecorator(object sender, RoutedEventArgs e)
    {
        weapon = new AimDecorator(weapon);
        this.AccuracyProgressBar.Value = weapon.Accuracy;
        this.SetAim.IsEnabled = false;
    }
   
}
