using System;

using Qorder.Models;
using Qorder.ViewModels;

using Xamarin.Forms;


namespace Qorder.Views
{
	public partial class Login : ContentPage
	{
        

        LoginViewModel viewModel;
        public Login()
		{ 
            // Initialize login View component

            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel();
        }
    }
}