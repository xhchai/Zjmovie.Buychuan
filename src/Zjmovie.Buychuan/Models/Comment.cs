using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Comment, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Comment
    {
        public Comment() { }

        #region 实体属性

        /// <summary>
        /// 评论ID
        /// </summary>
        [Display(Name = "评论ID")]
        public int? commentId { get; set; }

        /// <summary>
        /// 信息ID
        /// </summary>
        [Required]
        [Display(Name = "信息ID")]
        public int? infoId { get; set; }

        /// <summary>
        /// 评论人Id
        /// </summary>
        [Required]
        [Display(Name = "评论人Id")]
        public int? commenterId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [Required]
        [Display(Name = "评论内容")]
        [StringLength(200, ErrorMessage = "评论内容必须至少包含1个字符。", MinimumLength = 1)]
        public string commentContent { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        [Required]
        [Display(Name = "评论时间")]
        public DateTime? addTime { get; set; }

        /// <summary>
        /// 被回复的评论的ID
        /// </summary>
        [Required]
        [Display(Name = "被回复的评论的ID")]
        public long? refencentId { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Comment";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("commentId", "commentId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("infoId", "infoId");
            BaseField.Add("commenterId", "commenterId");
            BaseField.Add("commentContent", "commentContent");
            BaseField.Add("addTime", "addTime");
            BaseField.Add("refencentId", "refencentId");
            return BaseField;
        }
        #endregion

    }
}