using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zjmovie.Buychuan.Models
{
    /// <summary>
    /// 实体类 Info, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public class Info
    {
        public Info() { }

        #region 实体属性

        /// <summary>
        /// 信息ID
        /// </summary>
        [Display(Name = "信息ID")]
        public int? infoId { get; set; }

        /// <summary>
        /// 发布者Id
        /// </summary>
        [Required]
        [Display(Name = "发布者Id")]
        public int? publishId { get; set; }

        /// <summary>
        /// 图片JSON
        /// </summary>
        [Required]
        [Display(Name = "图片JSON")]
        [StringLength(8000, ErrorMessage = "图片JSON必须至少包含1个字符。", MinimumLength = 1)]
        public string ImagesJson { get; set; }

        /// <summary>
        /// 供求功能Id
        /// </summary>
        [Required]
        [Display(Name = "供求功能Id")]
        public int? supplyDemandFeatureId { get; set; }

        /// <summary>
        /// 审核员Id
        /// </summary>
        [Required]
        [Display(Name = "审核员Id")]
        public int? managerId { get; set; }

        /// <summary>
        /// 是否通过审核
        /// </summary>
        [Required]
        [Display(Name = "是否通过审核")]
        public bool? isVerify { get; set; }

        /// <summary>
        /// 是否允许评论
        /// </summary>
        [Required]
        [Display(Name = "是否允许评论")]
        public bool? isComment { get; set; }

        /// <summary>
        /// 信息JSON数据
        /// </summary>
        [Required]
        [Display(Name = "信息JSON数据")]
        [StringLength(8000, ErrorMessage = "信息JSON数据必须至少包含1个字符。", MinimumLength = 1)]
        public string jsonInfoData { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [Required]
        [Display(Name = "添加时间")]
        public DateTime? addTime { get; set; }

        /// <summary>
        /// 访问量
        /// </summary>
        [Required]
        [Display(Name = "访问量")]
        public long? visitTimes { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [Required]
        [Display(Name = "是否推荐")]
        public bool? isTuiJian { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [Required]
        [Display(Name = "评论数")]
        public long? commentCount { get; set; }

        /// <summary>
        /// 分享数
        /// </summary>
        [Required]
        [Display(Name = "分享数")]
        public long? sharetCount { get; set; }

        /// <summary>
        /// 分享数
        /// </summary>
        [Required]
        [Display(Name = "分享数")]
        public long? clickLickCount { get; set; }

        #endregion

        #region 实体属性Mapping
        /// <summary>
        /// 获取表名称
        /// </summary>
        public static string GetTableName()
        {
            return "Info";
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        public static Dictionary<string, string> GetIdentityMapping()
        {
            Dictionary<string, string> Identity = new Dictionary<string, string>();
            Identity.Add("infoId", "infoId");
            return Identity;
        }

        /// <summary>
        /// 获取基础字段
        /// </summary>
        public static Dictionary<string, string> GetBaseFieldMapping()
        {
            Dictionary<string, string> BaseField = new Dictionary<string, string>();
            BaseField.Add("publishId", "publishId");
            BaseField.Add("ImagesJson", "ImagesJson");
            BaseField.Add("supplyDemandFeatureId", "supplyDemandFeatureId");
            BaseField.Add("managerId", "managerId");
            BaseField.Add("isVerify", "isVerify");
            BaseField.Add("isComment", "isComment");
            BaseField.Add("jsonInfoData", "jsonInfoData");
            BaseField.Add("addTime", "addTime");
            BaseField.Add("visitTimes", "visitTimes");
            BaseField.Add("isTuiJian", "isTuiJian");
            BaseField.Add("commentCount", "commentCount");
            BaseField.Add("sharetCount", "sharetCount");
            BaseField.Add("clickLickCount", "clickLickCount");
            return BaseField;
        }
        #endregion

    }
}