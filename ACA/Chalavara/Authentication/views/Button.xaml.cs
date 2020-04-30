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
        }
        public async void Login(object sender, EventArgs e)
        {
            _googleManager.Login(OnLoginComplete);
        }

        private void OnLoginComplete(GoogleUser arg1, string arg2)
        {
           // throw new NotImplementedException();
        }
    }
}