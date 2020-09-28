using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lund : ContentPage
    {
        BoxView pea, amber, keha;
        Button btn1, btn2, btn3;
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //голова
            pea = new BoxView { Color = Color.LightBlue, CornerRadius = 50 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.1, 0.2, 300, 300));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);
            //тело
            keha = new BoxView { Color = Color.Blue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.5, 0.5, 300, 300));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);
            btn1 = new Button { Text = "Pea" };
            btn1.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.5, 0.8, 100, 100));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(btn1);
            Content = abs;



        }
        bool flag = true;

        private void Btn1_Clicked(object sender, EventArgs e)
        {
           if (flag)
           {
                pea.Opacity = 0;
                flag = false;
           }
           else
           {
                pea.Opacity = 1;
                flag = true;
           }
        }
    }
}