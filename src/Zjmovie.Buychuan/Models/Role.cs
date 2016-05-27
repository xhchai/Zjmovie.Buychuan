using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Role, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Role
    {
        public Role() { }

        #region 实体属性

        /// <summary>
        /// 角色Id
        /// </summary>
        [Display(Name = "角色Id")]
        public int? roleId { get; set; }

        /// <summary>
        /// 角色类型ID
        /// </summary>
        [Required]
        [Display(Name = "角色类型ID")]
        public int? rolesTypeId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        [Display(Name = "角色名称")]
        [StringLength(50, ErrorMessage = "角色名称必须至少包含1个字符。", MinimumLength = 1)]
        public string roleName { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [Required]
        [Display(Name = "角色描述")]
        [StringLength(200, ErrorMessage = "角色描述必须至少包含1个字符。", MinimumLength = 1)]
        public string roleDescription { get; set; }

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
            return "Role";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("roleId", "roleId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("rolesTypeId", "rolesTypeId");
            BaseField.Add("roleName", "roleName");
            BaseField.Add("roleDescription", "roleDescription");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}