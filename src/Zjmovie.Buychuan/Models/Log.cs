using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Log, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Log
    {
        public Log() { }

        #region 实体属性

        /// <summary>
        /// 日志Id
        /// </summary>
        [Display(Name = "日志Id")]
        public int? logId { get; set; }

        /// <summary>
        /// 事件信息
        /// </summary>
        [Required]
        [Display(Name = "事件信息")]
        [StringLength(50, ErrorMessage = "事件信息必须至少包含1个字符。", MinimumLength = 1)]
        public string eventInfo { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [Required]
        [Display(Name = "记录时间")]
        public DateTime? addTime { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Log";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("logId", "logId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("eventInfo", "eventInfo");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}