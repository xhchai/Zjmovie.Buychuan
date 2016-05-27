using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Authentication, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Authentication
    {
        public Authentication() { }

        #region 实体属性

        /// <summary>
        /// 认证ID
        /// </summary>
        [Display(Name = "认证ID")]
        public int? AuthenticationId { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        [Required]
        [Display(Name = "等级")]
        [StringLength(50, ErrorMessage = "等级必须至少包含1个字符。", MinimumLength = 1)]
        public string grade { get; set; }

        /// <summary>
        /// 等级图标
        /// </summary>
        [Required]
        [Display(Name = "等级图标")]
        [StringLength(50, ErrorMessage = "等级图标必须至少包含1个字符。", MinimumLength = 1)]
        public string gradePhoto { get; set; }

        /// <summary>
        /// 认证简述
        /// </summary>
        [Required]
        [Display(Name = "认证简述")]
        [StringLength(200, ErrorMessage = "认证简述必须至少包含1个字符。", MinimumLength = 1)]
        public string gradeDescripiton { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Authentication";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("AuthenticationId", "AuthenticationId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("grade", "grade");
            BaseField.Add("gradePhoto", "gradePhoto");
            BaseField.Add("gradeDescripiton", "gradeDescripiton");
            return BaseField;
        }
        #endregion

    }
}