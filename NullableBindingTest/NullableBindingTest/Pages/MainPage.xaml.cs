using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NullableBindingTest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            viewModel.ResetTextCommand = new Command(ResetText);
            viewModel.ResetNumbersCommand = new Command(ResetNumbers);
        }

        private void ResetText()
        {
            viewModel.Text = null;
        }

        private void ResetNumbers()
        {
            viewModel.Value = 0;
            viewModel.NullableValue = null;
        }
    }
}
