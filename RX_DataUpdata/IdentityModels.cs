using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace RX_DataUpdata
{
    public class RxUseManager : IdentityUser
    {

    }
    public class RxDbContext : IdentityDbContext<RxUseManager>
    {
        public RxDbContext():base ("IdentityDb")
        {

        }
        static RxDbContext()
        {
           
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
}

       