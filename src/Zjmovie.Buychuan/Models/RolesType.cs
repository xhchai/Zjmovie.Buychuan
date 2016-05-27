using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 RolesType, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class RolesType
    {
        public RolesType() { }

        #region 实体属性

        /// <summary>
        /// 角色类型ID
        /// </summary>
        [Display(Name = "角色类型ID")]
        public int? rolesTypeId { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [Required]
        [Display(Name = "角色类型")]
        [StringLength(50, ErrorMessage = "角色类型必须至少包含1个字符。", MinimumLength = 1)]
        public string roleType { get; set; }

        /// <summary>
        /// 角色类型描述
        /// </summary>
        [Required]
        [Display(Name = "角色类型描述")]
        [StringLength(200, ErrorMessage = "角色类型描述必须至少包含1个字符。", MinimumLength = 1)]
        public string roleTypeDescription { get; set; }

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
            return "RolesType";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("rolesTypeId", "rolesTypeId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("roleType", "roleType");
            BaseField.Add("roleTypeDescription", "roleTypeDescription");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}