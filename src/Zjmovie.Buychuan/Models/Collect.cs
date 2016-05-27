using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Collect, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Collect
    {
        public Collect() { }

        #region 实体属性

        /// <summary>
        /// 收藏ID
        /// </summary>
        [Display(Name = "收藏ID")]
        public int? collectId { get; set; }

        /// <summary>
        /// 信息ID
        /// </summary>
        [Display(Name = "信息ID")]
        [Required(ErrorMessage="信息ID不能为空。")]
        public int? infoId { get; set; }

        /// <summary>
        /// 收藏者Id
        /// </summary>
        [Required]
        [Display(Name = "收藏者Id")]
        public int? collecterId { get; set; }

        /// <summary>
        /// 收藏时间
        /// </summary>
        [Required]
        [Display(Name = "收藏时间")]
        public DateTime? collectTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Required]
        [Display(Name = "是否删除")]
        public bool? isDel { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Collect";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("collectId", "collectId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("infoId", "infoId");
            BaseField.Add("collecterId", "collecterId");
            BaseField.Add("collectTime", "collectTime");
            BaseField.Add("isDel", "isDel");
            return BaseField;
        }
        #endregion

    }
}