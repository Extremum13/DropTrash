using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.AppViewModels.UserViewModels.AuthorizationViewModels
{
    public class ResponsePersonalInformation
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool CanBeDriver { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
    }
}
