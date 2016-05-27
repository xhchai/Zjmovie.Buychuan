using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 RoleM2MFeatrue, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class RoleM2MFeatrue
    {
        public RoleM2MFeatrue() { }

        #region 实体属性

        /// <summary>
        /// 角色Id
        /// </summary>
        [Required]
        [Display(Name = "角色Id")]
        public int? roleId { get; set; }

        /// <summary>
        /// 功能Id
        /// </summary>
        [Required]
        [Display(Name = "功能Id")]
        public int? featureId { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "RoleM2MFeatrue";
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
            BaseField.Add("featureId", "featureId");
            return BaseField;
        }
        #endregion

    }
}