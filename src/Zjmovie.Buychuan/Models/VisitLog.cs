using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 VisitLog, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class VisitLog
    {
        public VisitLog() { }

        #region 实体属性

        /// <summary>
        /// 访问日志Id
        /// </summary>
        [Display(Name = "访问日志Id")]
        public int? VisitLogId { get; set; }

        /// <summary>
        /// 访问者Id
        /// </summary>
        [Required]
        [Display(Name = "访问者Id")]
        public int? visitId { get; set; }

        /// <summary>
        /// 信息ID
        /// </summary>
        [Required]
        [Display(Name = "信息ID")]
        public int? infoId { get; set; }

        /// <summary>
        /// 访问时间
        /// </summary>
        [Required]
        [Display(Name = "访问时间")]
        public DateTime? visitTime { get; set; }

        /// <summary>
        /// 访问设备信息
        /// </summary>
        [Required]
        [Display(Name = "访问设备信息")]
        [StringLength(200, ErrorMessage = "访问设备信息必须至少包含1个字符。", MinimumLength = 1)]
        public string visiterInfo { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "VisitLog";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("VisitLogId", "VisitLogId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("visitId", "visitId");
            BaseField.Add("infoId", "infoId");
            BaseField.Add("visitTime", "visitTime");
            BaseField.Add("visiterInfo", "visiterInfo");
            return BaseField;
        }
        #endregion

    }
}