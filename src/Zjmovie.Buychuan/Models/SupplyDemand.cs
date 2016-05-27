using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 SupplyDemand, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class SupplyDemand
    {
        public SupplyDemand() { }

        #region 实体属性

        /// <summary>
        /// 供求功能Id
        /// </summary>
        [Display(Name = "供求功能Id")]
        public int? supplyDemandFeatureId { get; set; }

        /// <summary>
        /// 功能模板名称
        /// </summary>
        [Required]
        [Display(Name = "功能模板名称")]
        [StringLength(50, ErrorMessage = "功能模板名称必须至少包含1个字符。", MinimumLength = 1)]
        public string featureName { get; set; }

        /// <summary>
        /// 供求类型
        /// </summary>
        [Required]
        [Display(Name = "供求类型")]
        public int? supplyDemandType { get; set; }

        /// <summary>
        /// JSON模板
        /// </summary>
        [Required]
        [Display(Name = "JSON模板")]
        [StringLength(8000, ErrorMessage = "JSON模板必须至少包含1个字符。", MinimumLength = 1)]
        public string jsonTemplate { get; set; }

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
            return "SupplyDemand";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("supplyDemandFeatureId", "supplyDemandFeatureId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("featureName", "featureName");
            BaseField.Add("supplyDemandType", "supplyDemandType");
            BaseField.Add("jsonTemplate", "jsonTemplate");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}