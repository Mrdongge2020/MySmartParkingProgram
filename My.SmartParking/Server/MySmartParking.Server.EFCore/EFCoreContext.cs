using Microsoft.EntityFrameworkCore;
using My.SmartParking.Server.Models;
using System;
using System.Data;

namespace MySmartParking.Server.EFCore
{
    public class EFCoreContext:DbContext
    {
        private string strConn = "Server=47.109.107.251,1433;database=My.SmartParking;uid=sa;pwd=LDSsql20231106;TrustServerCertificate=true";

        public EFCoreContext()
        {
            
        }
        public EFCoreContext(string strConn) 
        {
            this.strConn = strConn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(strConn);
            base.OnConfiguring(optionsBuilder);
        }
        /// <summary>
        /// 用户信息
        /// </summary>
        public DbSet<SysUserInfo> SysUserInfos { get; set; }
    }
}
