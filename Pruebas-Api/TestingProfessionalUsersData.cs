using MedicalReservationsApp.Server.Controllers;
using MedicalReservationsApp.Server.interfaces;
using MedicalReservationsApp.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Pruebas_Api
{
    public class TestingProfessionalUsersData
    {

        [Fact]
        public async Task Post_ReturnsProfessionalUsers()
        {
            ProfessionalUsers Users = new ProfessionalUsers { IdProfessionalUsers = 1,Name = "" };

            var mockUsercontrollers = new Mock<IProfesionalUsersController>();
            mockUsercontrollers.Setup(users => users.PostProfessionalUsers(It.IsAny<ProfessionalUsers>())).ReturnsAsync(new ActionResult<ProfessionalUsers>(Users));
            var result = await  mockUsercontrollers.Object.PostProfessionalUsers(Users);
            Assert.NotNull(Users.Institution);
            Assert.NotNull(result);



        }
    }
}