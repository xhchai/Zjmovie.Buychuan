using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Manager, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Manager: ApplicationUser
    {
        public Manager() { }

        #region 实体属性

        /// <summary>
        /// 管理员Id
        /// </summary>
        [Display(Name = "管理员Id")]
        public int? managerId { get; set; }

        /// <summary>
        /// 管理角色Id
        /// </summary>
        [Required]
        [Display(Name = "管理角色Id")]
        public int? manageRoleId { get; set; }

        /// <summary>
        /// 管理员姓名
        /// </summary>
        [Required]
        [Display(Name = "管理员姓名")]
        [StringLength(50, ErrorMessage = "管理员姓名必须至少包含1个字符。", MinimumLength = 1)]
        public string myName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [Display(Name = "用户名")]
        [StringLength(50, ErrorMessage = "用户名必须至少包含1个字符。", MinimumLength = 1)]
        public string userName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [Display(Name = "密码")]
        [StringLength(50, ErrorMessage = "密码必须至少包含1个字符。", MinimumLength = 1)]
        public string thePassword { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [Required]
        [Display(Name = "添加时间")]
        public DateTime? addTime { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Manager";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("managerId", "managerId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("manageRoleId", "manageRoleId");
            BaseField.Add("myName", "myName");
            BaseField.Add("userName", "userName");
            BaseField.Add("thePassword", "thePassword");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}