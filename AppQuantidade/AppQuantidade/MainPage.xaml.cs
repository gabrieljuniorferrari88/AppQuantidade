using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        private int count = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void HandleIncrease(object sender, EventArgs e)
        {
            count++;
            LblCount.Text = count.ToString();
        }

        private void HandleDecrease(object sender, EventArgs e)
        {
            if (count != 0)
            {
                count--;
                LblCount.Text = count.ToString();
            }
        }
    }
}