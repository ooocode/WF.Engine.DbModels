using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public class OpinionTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 跟踪名称
        /// </summary>
        [Required]
        public string TrackingName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        public string UserName { get; set; }


        /// <summary>
        /// 用户显示名称
        /// </summary>
        public string UserDisplayName { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        public string UserPhoneNumber { get; set; }

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
        public DateTimeOffset CreateDateTime { get; set; }

        /// <summary>
        /// 编辑日期
        /// </summary>
        public DateTimeOffset? EditDateTime { get; set; }

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
