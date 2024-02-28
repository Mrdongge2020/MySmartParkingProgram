using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My.SmartParking.Server.Models
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Table("SysUserInfos")]
    public class SysUserInfo
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Column("UserName")]
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Column("Password")]
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
