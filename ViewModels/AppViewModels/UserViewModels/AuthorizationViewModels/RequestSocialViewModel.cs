using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Enum;

namespace ViewModels.AppViewModels.UserViewModels.AuthorizationViewModels
{
    public class RequestSocialViewModel
    {
        public string SocialId { get; set; }
        public SocialMedia SocialMedia { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool CanBeDriver { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
    }
}
