using BenDan.ApplicationCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenDan.Services
{
    public interface IUserService
    {
        Task<User> User { get; }
    }
    public class UserServices:IUserService
    {
        public UserManager<User> UserManager { get; }
        private IHttpContextAccessor Context;
        public UserServices(UserManager<User> userManager, IHttpContextAccessor context)
        {
            UserManager = userManager;
            Context = context;
        }
        public Task<User> User
        {
            get
            {
                return UserManager.GetUserAsync(Context.HttpContext.User);
            }
        }
    }
}
