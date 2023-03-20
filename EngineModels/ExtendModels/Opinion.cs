using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public class Opinion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }


        /// <summary>
        /// 意见类型Id
        /// </summary>
        public int OpinionTypeId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        public string UserName { get; set; }


        /// <summary>
        /// 用户部门名称(为什么加入？因为用户可能会更换部门)
        /// </summary>
        public string UserDepartmentName { get; set; }


        /// <summary>
        /// 唯一业务编号
        /// </summary>
        [Required]
        public string BusinessKey { get; set; }


        /// <summary>
        /// 当前的活动状态
        /// </summary>
        [Required]
        public string ActivityKey { get; set; }


        /// <summary>
        /// 当前的活动状态
        /// </summary>
        [Required]
        public string ActivityName { get; set; }


        /// <summary>
        /// 意见
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 是否暂存(如果暂存则不公开)
        /// </summary>
        public bool IsTempSave { get; set; }

        /// <summary>
        /// 浏览器用户代理
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        public string ClientIpAddress { get; set; }
    }
}
