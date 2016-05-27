using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Publisher, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Publisher:ApplicationUser
    {
        public Publisher() { }

        #region 实体属性

        /// <summary>
        /// 发布者Id
        /// </summary>
        [Display(Name = "发布者Id")]
        public int? publishId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        [Required]
        [Display(Name = "角色Id")]
        public int? roleId { get; set; }

        /// <summary>
        /// 认证ID
        /// </summary>
        [Required]
        [Display(Name = "认证ID")]
        public int? AuthenticationId { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [Display(Name = "手机")]
        [Required(ErrorMessage="手机不能为空。")]
        [StringLength(11, ErrorMessage = "手机必须至少包含1个字符。", MinimumLength = 1)]
        public string mob { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [Display(Name = "密码")]
        [StringLength(32, ErrorMessage = "密码必须至少包含1个字符。", MinimumLength = 1)]
        public string thePassword { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [Required]
        [Display(Name = "注册时间")]
        public DateTime? regTime { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Required]
        [Display(Name = "头像")]
        [StringLength(50, ErrorMessage = "头像必须至少包含1个字符。", MinimumLength = 1)]
        public string headPhoto { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [Display(Name = "姓名")]
        [StringLength(50, ErrorMessage = "姓名必须至少包含1个字符。", MinimumLength = 1)]
        public string myName { get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        [Required]
        [Display(Name = "认证信息")]
        [StringLength(8000, ErrorMessage = "认证信息必须至少包含1个字符。", MinimumLength = 1)]
        public string authenticationInfo { get; set; }

        /// <summary>
        /// 发布者身份
        /// </summary>
        [Required]
        [Display(Name = "发布者身份")]
        [StringLength(50, ErrorMessage = "发布者身份必须至少包含1个字符。", MinimumLength = 1)]
        public string publishIdentity { get; set; }

        /// <summary>
        /// 用户是否禁用
        /// </summary>
        [Required]
        [Display(Name = "用户是否禁用")]
        public bool? isActivity { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Publisher";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("publishId", "publishId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("roleId", "roleId");
            BaseField.Add("AuthenticationId", "AuthenticationId");
            BaseField.Add("mob", "mob");
            BaseField.Add("thePassword", "thePassword");
            BaseField.Add("regTime", "regTime");
            BaseField.Add("headPhoto", "headPhoto");
            BaseField.Add("myName", "myName");
            BaseField.Add("authenticationInfo", "authenticationInfo");
            BaseField.Add("publishIdentity", "publishIdentity");
            BaseField.Add("isActivity", "isActivity");
            return BaseField;
        }
        #endregion

    }
}