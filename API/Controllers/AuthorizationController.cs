using Business.EntityService.Interface;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.AppViewModels.UserViewModels.AuthorizationViewModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class AuthorizationController : Controller
    {
        private IAuthorizationService authorizationService;
        private IUnitOfWork unitOfWork;

        public AuthorizationController(IAuthorizationService authorizationService, IUnitOfWork unitOfWork)
        {
            this.authorizationService = authorizationService;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponsePersonalInformation GetPersonById(int id)
        {
            var person = this.unitOfWork.PersonRepository.GetById(id);
            ResponsePersonalInformation personalInformation = 
                new ResponsePersonalInformation { BirthDay = person.Birthday.Day, BirthMonth = person.Birthday.Month, BirthYear = person.Birthday.Year, CanBeDriver = person.CanBeDriver, FirstName = person.FirstName, SecondName = person.SecondName };

            return personalInformation;
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreatePerson(RequestSocialViewModel socialViewModel)
        {
            SocialMedia socialMedia;
            switch(socialViewModel.SocialMedia)
            {
                case (ViewModels.Enum.SocialMedia.Facebook):
                    socialMedia = SocialMedia.Facebook;
                    break;
                case (ViewModels.Enum.SocialMedia.Google):
                    socialMedia = SocialMedia.Google;
                    break;
                default:
                    socialMedia = SocialMedia.Google;
                    break;
            }

            DateTime dateTime = new DateTime(socialViewModel.BirthYear, socialViewModel.BirthMonth, socialViewModel.BirthYear);
            Person person = this.authorizationService.CreatePersonBySocial(socialViewModel.SocialId, socialMedia, socialViewModel.FirstName, socialViewModel.SecondName, dateTime, socialViewModel.CanBeDriver);
                        
            return this.Ok(person);
        }
    }
}
