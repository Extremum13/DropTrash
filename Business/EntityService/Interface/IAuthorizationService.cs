using Domain.Entity;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityService.Interface
{
    public interface IAuthorizationService
    {
        Person CreatePersonBySocial(string socialId, SocialMedia socialMedia, string FirstName, string SecondName, DateTime birthDate, bool canBeDriver);
    }
}
