using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendFields
{
    public class RuTask
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [Column("business_key")]
        public string BusinessKey { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("create_date_time_offset")]
        public DateTimeOffset? CreateDateTimeUtc { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        [Column("follow_up_date_time_offset")]
        public DateTimeOffset? AssigneeDateTime { get; set; }

        /// <summary>
        /// 刚创建的？处于第一个用户节点，没有流转
        /// </summary>
        [Column("is_first_user_task")]
        public bool? IsJustCreated { get; set; }


        [Column("pre_user_task_id")]
        public string PreUserTaskId { get; set; }


        [Column("sender_user_name")]
        public string SenderUserName { get; set; }

        /// <summary>
        /// 暂存意见
        /// </summary>
        [Column("temp_opinion")]
        public string TempSaveOpinion { get; set; }



        /// <summary>
        /// 暂存业务表单
        /// </summary>
        [Column("temp_business_form")]
        public string TempSaveBusinessForm { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }


        /// <summary>
        /// 跟踪名称
        /// </summary>
        [Column("ex_tracking_name")]
        [StringLength(255)]
        public string ExTrackingName { get; set; }


        /// <summary>
        /// 签收人姓名
        /// </summary>
        [Column("ex_assignee_displayname")]
        [StringLength(1024)]
        public string AssigneeDisplayName { get; set; }


        /// <summary>
        /// 签收人部门
        /// </summary>
        [Column("ex_assignee_department")]
        [StringLength(1024)]
        public string AssigneeDepartment { get; set; }
    }
}
