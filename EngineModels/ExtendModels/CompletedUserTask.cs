using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    /// <summary>
    /// 完成的用户任务
    /// </summary>
    [Table("ex_completed_user_task")]
    public class CompletedUserTask
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("business_key")]
        public string BusinessKey { get; set; }

        [Column("core_attach")]
        public string CoreAttach { get; set; }

        [Column("custom_attach")]
        public string CustomAttach { get; set; }

        [Column("next_user_tasks")]
        public string NextUserTasks { get; set; }

        [Column("create_date_time_offset")]
        public DateTimeOffset CreateDateTimeOffset { get; set; }

        [Column("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [Column("faild_reason")]
        public string FaildReason { get; set; }

        /// <summary>
        /// 锁定结束时间
        /// </summary>
        [Column("lock_end_date_time")]
        public DateTimeOffset? LockEndDateTime { get; set; }

        /// <summary>
        /// 最后一次执行时间
        /// </summary>
        [Column("last_execute_date_time_offset")]
        public DateTimeOffset? LastExecuteDateTimeOffset;
    }
}
