using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 MobMsg, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class MobMsg
    {
        public MobMsg() { }

        #region 实体属性

        /// <summary>
        /// 手机信息ID
        /// </summary>
        [Display(Name = "手机信息ID")]
        public int? mobMsgId { get; set; }

        /// <summary>
        /// 发布者Id
        /// </summary>
        [Required]
        [Display(Name = "发布者Id")]
        public int? publishId { get; set; }

        /// <summary>
        /// 信息类型ID
        /// </summary>
        [Required]
        [Display(Name = "信息类型ID")]
        public int? infoTypeId { get; set; }

        /// <summary>
        /// 内容信息
        /// </summary>
        [Required]
        [Display(Name = "内容信息")]
        [StringLength(50, ErrorMessage = "内容信息必须至少包含1个字符。", MinimumLength = 1)]
        public string msg { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [Required]
        [Display(Name = "发送时间")]
        public DateTime? sendTime { get; set; }

        /// <summary>
        /// 信息是否送达
        /// </summary>
        [Required]
        [Display(Name = "信息是否送达")]
        public bool? isDeliver { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "MobMsg";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("mobMsgId", "mobMsgId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("publishId", "publishId");
            BaseField.Add("infoTypeId", "infoTypeId");
            BaseField.Add("msg", "msg");
            BaseField.Add("sendTime", "sendTime");
            BaseField.Add("isDeliver", "isDeliver");
            return BaseField;
        }
        #endregion

    }
}