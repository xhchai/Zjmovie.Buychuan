using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 TheKeyworlds, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class TheKeyworlds
    {
        public TheKeyworlds() { }

        #region 实体属性

        /// <summary>
        /// 关键字Id
        /// </summary>
        [Display(Name = "关键字Id")]
        public int? keyworldsId { get; set; }

        /// <summary>
        /// 过滤词
        /// </summary>
        [Required]
        [Display(Name = "过滤词")]
        [StringLength(50, ErrorMessage = "过滤词必须至少包含1个字符。", MinimumLength = 1)]
        public string filterWords { get; set; }

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
            return "TheKeyworlds";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("keyworldsId", "keyworldsId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("filterWords", "filterWords");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}