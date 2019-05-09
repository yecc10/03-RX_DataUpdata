using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Security;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
namespace RX_DataUpdata
{
        public class UserManager
    {
        public UserManager()
        {

        }
        /// <summary>
        /// 注册用户
        /// </summary>
        public void Create_A_User()
        {
            // _session is a valid NHibernate ISession object
            using (var userStore = new RxUserStore<RxIdentityUser>(_session))
            using (var userManager = new UserManager<RxIdentityUser>(Store))
            {
                var user = new RxIdentityUser
                {
                    UserName = "kenny_mccormick",
                    RolesStr = "admin",
                    Acc="E1",

                };

                var createTask = userManager.CreateAsync(user, "the_password");

                var result = createTask.Result; // this never finishes...
            }
        }

        public class RxIdentityUser : IUser
            {
                /// <summary>
                /// 用户ID
                /// </summary>
                public virtual Guid UserId { get; set; }
                /// <summary>
                /// HashPassword
                /// </summary>
                public virtual string PasswordHash { get; set; }
                /// <summary>
                /// 秘钥戳
                /// </summary>
                public virtual string SecurityStamp { get; set; }
                /// <summary>
                /// 角色
                /// </summary>
                public virtual string RolesStr { get; set; }
                /// <summary>
                /// 用户名
                /// </summary>
                public virtual string UserName { get; set; }
                 /// <summary>
                 /// 权限E1,E2,E3......E99
                 /// </summary>
                 public virtual string Acc { get; set; }
                 /// <summary>
                 /// 所在科室
                 /// </summary>
                 public virtual string keshi { get; set; }
            public virtual string Id
                {
                    get { return UserId.ToString(); }
                }
            }
        public class RxUserStore<TUser> :
        IUserPasswordStore<TUser>,
        IUserRoleStore<TUser>,
        IUserSecurityStampStore<TUser>
    where TUser : RxIdentityUser
        {
            // ReSharper disable once StaticFieldInGenericType
            private static readonly Task EmptyTask = new Task(() => { });

            private readonly ISession _session;

            public RxUserStore(ISession session)
            {
                _session = session;
            }

            public Task<TUser> FindAsync(UserLoginInfo login)
            {
                return Task.FromResult((TUser)null);
            }

            public Task CreateAsync(TUser user)
            {
                Action action = () => _session.Save(user);
                return Task.Run(action);

                _session.Save(user);
                return EmptyTask;
            }

            public Task UpdateAsync(TUser user)
            {
                // updates will (hopefully) be saved automatically when the current session is committed
                return EmptyTask;
            }

            public Task DeleteAsync(TUser user)
            {
                _session.Delete(user);
                return EmptyTask;
            }

            public Task<TUser> FindByIdAsync(string userId)
            {
                TUser user = null;
                Guid guidId;

                if (Guid.TryParse(userId, out guidId))
                    user = _session.Get<TUser>(guidId);

                return Task.FromResult(user);
            }

            public Task<TUser> FindByNameAsync(string userName)
            {
                TUser user = _session.Query<TUser>().SingleOrDefault(u => u.UserName == userName);
                return Task.FromResult(user);
            }

            public Task SetPasswordHashAsync(TUser user, string passwordHash)
            {
                user.PasswordHash = passwordHash;
                return EmptyTask;
            }

            public Task<string> GetPasswordHashAsync(TUser user)
            {
                return Task.FromResult(user.PasswordHash);
            }

            public Task<bool> HasPasswordAsync(TUser user)
            {
                return Task.FromResult(user.PasswordHash != null);
            }

            public void Dispose()
            {
            }

            public Task AddToRoleAsync(TUser user, string role)
            {
                new SimpleRoleManager<TUser>(user).AddRole(role);

                return EmptyTask;
            }

            public Task RemoveFromRoleAsync(TUser user, string role)
            {
                new SimpleRoleManager<TUser>(user).DeleteRole(role);

                return EmptyTask;
            }

            public Task<IList<string>> GetRolesAsync(TUser user)
            {
                List<string> roles = new SimpleRoleManager<TUser>(user).GetRoles().ToList();

                return Task.FromResult((IList<string>)roles);
            }

            public Task<bool> IsInRoleAsync(TUser user, string role)
            {
                return Task.FromResult(new SimpleRoleManager<TUser>(user).IsInRole(role));
            }

            public Task SetSecurityStampAsync(TUser user, string stamp)
            {
                user.SecurityStamp = stamp;
                return EmptyTask;
            }

            public Task<string> GetSecurityStampAsync(TUser user)
            {
                return Task.FromResult(user.SecurityStamp);
            }
        }
        public class SimpleRoleManager<TUser> where TUser : RxIdentityUser
        {
            private const string Separator = "|";

            private readonly TUser _user;

            public SimpleRoleManager(TUser user)
            {
                _user = user;
            }

            public string[] GetRoles()
            {
                return (_user.RolesStr ?? String.Empty)
                    .Split(Separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            public bool IsInRole(string roleName)
            {
                return GetRoles().Contains(roleName);
            }

            public bool AddRole(string roleName)
            {
                var roles = GetRoles().ToList();

                if (roles.Contains(roleName))
                    return false;

                roles.Add(roleName);
                SetRoles(roles);
                return true;
            }

            public bool DeleteRole(string roleName)
            {
                List<string> roles = GetRoles().ToList();

                if (!roles.Contains(roleName))
                    return false;

                roles.Remove(roleName);
                SetRoles(roles);
                return true;
            }

            private void SetRoles(IEnumerable<string> roles)
            {
                _user.RolesStr = String.Join(Separator, roles);
            }
        }


    }

}
