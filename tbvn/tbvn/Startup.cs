﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using tbvn.Models;

[assembly: OwinStartupAttribute(typeof(tbvn.Startup))]
namespace tbvn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateRolesandUserAdmin();
        }

        //private void CreateRolesandUserAdmin()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


        //    // In Startup iam creating first Admin Role and creating a default Admin User    
        //    if (!roleManager.RoleExists("Administrator"))
        //    {
        //        // first we create Admin rool   
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Administrator";
        //        roleManager.Create(role);

        //        //Here we create a Admin super user who will maintain the website                  

        //        var user = new ApplicationUser();
        //        user.UserName = "admin";
        //        user.Email = "nguyenvannam0411@gmail.com";
        //        user.EmailConfirmed = true;
        //        string userPWD = "abc@123";

        //        var chkUser = UserManager.Create(user, userPWD);

        //        //Add default User to Role Admin   
        //        if (chkUser.Succeeded)
        //        {
        //            var result1 = UserManager.AddToRole(user.Id, "Administrator");
        //        }
        //    }


        //}
    }
}
