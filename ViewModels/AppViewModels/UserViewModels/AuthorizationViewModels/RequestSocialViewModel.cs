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
    }
}
