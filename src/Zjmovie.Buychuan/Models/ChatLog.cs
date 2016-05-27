using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 ChatLog, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class ChatLog
    {
        public ChatLog() { }

        #region 实体属性

        /// <summary>
        /// 聊天记录ID
        /// </summary>
        [Display(Name = "聊天记录ID")]
        public int? ChatLogId { get; set; }

        /// <summary>
        /// 发送人Id
        /// </summary>
        [Required]
        [Display(Name = "发送人Id")]
        public int? senderId { get; set; }

        /// <summary>
        /// 发布者Id
        /// </summary>
        [Required]
        [Display(Name = "发布者Id")]
        public int? receiverId { get; set; }

        /// <summary>
        /// 信息内容
        /// </summary>
        [Required]
        [Display(Name = "信息内容")]
        [StringLength(200, ErrorMessage = "信息内容必须至少包含1个字符。", MinimumLength = 1)]
        public string theContent { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [Required]
        [Display(Name = "发布时间")]
        public DateTime? addTime { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "ChatLog";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("ChatLogId", "ChatLogId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("senderId", "senderId");
            BaseField.Add("receiverId", "receiverId");
            BaseField.Add("theContent", "theContent");
            BaseField.Add("addTime", "addTime");
            return BaseField;
        }
        #endregion

    }
}