using Admin.BusinessLogicLayer.Abstract;
using Admin.EntityLayer.POCO;
using Microsoft.AspNetCore.Mvc;

namespace Admin.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        IAdminService adminservice;
        public AdminController(IAdminService AdminService)
        {
               adminservice = AdminService;
        }
        [HttpGet("GetAdmins")]
        public ActionResult GetAdmins() 
        {
            var admins = adminservice.GetAll();
            return Ok(admins);
        }
        [HttpGet("GetAdmin")]
        public ActionResult GetAdmin(int id) 
        {
            var admin = adminservice.Get(id);
            return Ok(admin);
        }
        [HttpPost("addadmin")]
        public ActionResult AddAdmin(Admins Admin) 
        {
            var result = adminservice.Add(Admin);
            return Ok(result);
        }
        [HttpPost("deleteadming")]
        public ActionResult DeleteAdmin(Admins Admin) 
        {
            var result = adminservice.Delete(Admin);
            return Ok(result);
        }
        [HttpPost("updateadmin")]
        public ActionResult UpdateAdmin(Admins Admin) 
        {
            var result = adminservice.Update(Admin);
            return Ok(result);
        }
    }
}
