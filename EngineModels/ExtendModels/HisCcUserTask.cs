using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    /// <summary>
    /// 已完成的抄送任务
    /// </summary>
    [Table("ex_hi_cc_usertask")]
    public class HisCcUserTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusinessKey { get; set; }


        public string UserName { get; set; }

        public string UserDisplayName { get; set; }

        public string UserDepartment { get; set; }


        public string SenderUserName { get; set; }

        public string SenderDisplayName { get; set; }

        public string SenderUserDepartment { get; set; }


        /// <summary>
        /// 处理定义Id
        /// </summary>
        public string ProcessDefId { get; set; }

        /// <summary>
        /// 处理定义key
        /// </summary>
        public string ProcessDefKey { get; set; }

        /// <summary>
        /// 处理定义名称
        /// </summary>
        public string ProcessDefName { get; set; }


        public string TaskDefKey { get; set; }

        public string TaskName { get; set; }


        public DateTimeOffset CreateDateTime { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        public DateTimeOffset? AssigneeDateTime { get; set; }


        /// <summary>
        /// 自定义标记
        /// </summary>
        [MaxLength(256)]
        public string Tag { get; set; }
    }
}
