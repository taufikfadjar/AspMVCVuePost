using AspMVCVuePost.Lib.Utils;
using AspMVCVuePost.Repository.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVCVuePost.Service
{
    public interface IAccountService
    {
        ResponseResult CreateUser(User user, string password);
        ResponseResult CreateRole(string name);
    }
    public class AccountService  : IAccountService
    {

        private UserManager<User> Usermanager { get; set; }
        private RoleManager<IdentityRole> Rolemanager { get; set; }
        public AccountService(
            UserManager<User> usermanager,
            RoleManager<IdentityRole> roleManager
            )
        {
            Usermanager = usermanager;
            Rolemanager = roleManager;
        }

        public ResponseResult CreateUser(User user, string password)
        {
            var getUser = Usermanager.FindByName(user.UserName);

            if (getUser != null)
            {
                return ResponseResult.CreateFail("Gagal membuat user");
            }

            var result = Usermanager.Create(user, password);

            if (result.Succeeded)
            {
                return ResponseResult.CreateSuccess("Sukses membuat user");
            }

            return ResponseResult.CreateFail("Gagal membuat user");
        }


        public ResponseResult DeleteUser(string username)
        {
            var getUser = Usermanager.FindByName(username);
            if (getUser == null)
            {
                return ResponseResult.CreateFail("Sukses mendelete user");
            }
            var result = Usermanager.Delete(getUser);

            if (result.Succeeded)
            {
                return ResponseResult.CreateSuccess("Sukses mendelete user");
            }

            return ResponseResult.CreateFail("Gagal mendelete user");
        }

        public ResponseResult CreateRole(string name)
        {
            var getRole = Rolemanager.FindByName(name);

            if (getRole != null)
            {
                return ResponseResult.CreateFail("Gagal membuat role");
            }

            var result = Rolemanager.Create(new IdentityRole(name));

            if (result.Succeeded)
            {
                return ResponseResult.CreateSuccess("Sukses membuat role");
            }

            return ResponseResult.CreateFail("Gagal membuat role");
        }
    }
}
