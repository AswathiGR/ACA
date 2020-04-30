using System;
using System.Collections.Generic;
using System.Text;

namespace ACA.Chalavara.Authentication.Model
{
    public class GoogleUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Uri Picture { get; set; }
        public string Token { get; set; }
    }
}
