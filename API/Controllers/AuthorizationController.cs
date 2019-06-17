using Business.EntityService.Interface;
using Data.EF.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AuthorizationController : Controller
    {
        private IAuthorizationService authorizationService;
        private IUnitOfWork unitOfWork;

        public AuthorizationController(IAuthorizationService authorizationService, IUnitOfWork unitOfWork)
        {
            this.authorizationService = authorizationService;
            this.unitOfWork = unitOfWork;
        }


    }
}
