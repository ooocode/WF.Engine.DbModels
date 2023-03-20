using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    /// <summary>
    /// 已办任务表
    /// </summary>
    [Table("NewestCompletedTasks")]
    public class NewestCompletedTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 所有者
        /// </summary>
        [Required]
        public string OwnerUserName { get; set; }


        public string OwnerName { get; set; }

        public string OwnerDepartmentName { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusinessKey { get; set; }

        /// <summary>
        /// 当前活动节点Id
        /// </summary>
        public string ActivityId { get; set; }

        /// <summary>
        /// 当前活动节点名称
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// 处理定义Id
        /// </summary>
        public string ProcessDefId { get; set; }


        /// <summary>
        /// 处理定义Key
        /// </summary>
        public string ProcessDefKey { get; set; }

        /// <summary>
        /// 处理定义
        /// </summary>
        public string ProcessDefName { get; set; }

        /// <summary>
        /// 执行Id
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// 处理实例Id
        /// </summary>
        public string ProcInstId { get; set; }

        /// <summary>
        /// 发送选择
        /// </summary>
        public string DisposeName { get; set; }

        /// <summary>
        /// 发送选择值
        /// </summary>
        public string DisposeValue { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public string SenderUserName { get; set; }

        public string SenderName { get; set; }

        public string SenderDepartmentName { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// 填写的意见
        /// </summary>
        public string Opinion { get; set; }


        /// <summary>
        /// 签收日期
        /// </summary>
        public DateTime? AssigneeDateTime { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime? DealDateTime { get; set; }


        /// <summary>
        /// 跟踪名称
        /// </summary>
        [Column("tracking_name")]
        [StringLength(255)]
        public string TrackingName { get; set; }

        /// <summary>
        /// 任务授权人用户名
        /// </summary>
        [Column("task_origin_owner_user_name")]
        [StringLength(255)]
        public string TaskOriginOwnerUserName { get; set; }
    }
}