using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lund
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label label1 = new Label()
            {
                Text = "Первая метка",
                TextColor = Color.Red
            };
            InitializeComponent();
        }
    }
}
