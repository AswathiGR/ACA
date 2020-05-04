using ACA.Chalavara.Authentication.interfaces;
using ACA.Chalavara.Authentication.intrefaces;
using ACA.Chalavara.Authentication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACA.Chalavara.Authentication.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Button : ContentPage
    {
        public static IGoogleAuthenticator _googleManager = DependencyService.Get<IGoogleAuthenticator>();
        public GoogleUser GoogleUser { get; private set; }
        public bool IsLogedIn { get; private set; }




        public Button()
        {
            InitializeComponent();

            AnimateIn();
        }
        public async void AnimateIn()
        {

            light1.FadeTo(0, 0);
            light2.FadeTo(0, 0);
            clock.FadeTo(0, 0);
            login.FadeTo(0, 0);
            label1.FadeTo(0, 0);
            frame.FadeTo(0.0);
            label2.FadeTo(0, 0);
            light1.TranslationY = -200;
            light2.TranslationY = -160;
            clock.TranslationY = 60;
            label1.TranslationY = 40; 
            login.TranslationY = 40;
            frame.TranslationY = 40;
            label2.TranslationY = 30;

            light1.FadeTo(1, 600);
            await light1.TranslateTo(0, 0, 300);
           
            light2.FadeTo(1, 500);
            await light2.TranslateTo(0, 0, 300);

            clock.FadeTo(1, 400);
            await clock.TranslateTo(0, 0, 300);
            frame.FadeTo(1, 400);
            await frame.TranslateTo(0, 0, 300);
            login.FadeTo(1, 400);
            await login.TranslateTo(0, 0, 300);
            label1.FadeTo(1, 400);
            await label1.TranslateTo(0, 0, 300);
            label2.FadeTo(1, 400);
            await label2.TranslateTo(0, 0, 300);

        }
    }
}


        //private async void Login(object sender, EventArgs e)
        // {
        //  try
        //{

        //  _googleManager.Logout();
        //_googleManager.Login(OnLoginComplete);

        //}
        //catch (Exception x)
        //{

        //  await DisplayAlert("Authentication Failed", "Your Authentication Attempt Failed. Please try again..", "Ok");
        //}
        //}

        //  private async void OnLoginComplete(GoogleUser googleUser, string message)
        //{
        //  if (googleUser != null)
        //{
        //  GoogleUser = googleUser;
        //try
        //{
        //  AppUser User = await DependencyService.Get<IFireBaseAuthenticator>().LoginWithGoogle(googleUser.Token, null);
        //Application.Current.Properties["User"] = User.Uid;
        //}
        //catch (Exception e)
        //{
        //  await DisplayAlert("Oops", "Firebase Error", "Ok");

        //}

        //  IsLogedIn = true;
        //await DisplayAlert("Success", message, "Ok");

        // }
        //else
        //{

        //  await DisplayAlert("Error", message, "Ok");
        //}
        //}

    


