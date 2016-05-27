using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 InfoType, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class InfoType
    {
        public InfoType() { }

        #region 实体属性

        /// <summary>
        /// 信息类型ID
        /// </summary>
        [Display(Name = "信息类型ID")]
        public int? infoTypeId { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        [Display(Name = "类型名称")]
        [StringLength(50, ErrorMessage = "类型名称必须至少包含1个字符。", MinimumLength = 1)]
        public string typeName { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [Required]
        [Display(Name = "过期时间")]
        public DateTime? expandTime { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "InfoType";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("infoTypeId", "infoTypeId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("typeName", "typeName");
            BaseField.Add("expandTime", "expandTime");
            return BaseField;
        }
        #endregion

    }
}