using Microsoft.AspNetCore.Mvc;
using SukaHospital.Services;

namespace SukaHospital.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
       
        private IApplicationUserService _userService;

        public UsersController(IApplicationUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index(int PageNumber=1, int PageSize=10)
        {
            return View(_userService.GetAll(PageNumber,PageSize));
        }
        public IActionResult AllDoktors(int PageNumber = 1, int PageSize = 10)
        {
            return View(_userService.GetAllDoktor(PageNumber, PageSize));
        }
    }
}
