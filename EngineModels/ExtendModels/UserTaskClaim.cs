using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WF.Engine.DbModels.Consts;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    /// <summary>
    /// 用户任务声明
    /// </summary>
    public class UserTaskClaim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(DbFiledConsts.DefaultLength)]
        public string UserName { get; set; }

        /// <summary>
        /// 唯一业务编号
        /// </summary>
        [Required]
        [StringLength(DbFiledConsts.DefaultLength)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// 声明类型
        /// </summary>
        [Required]
        [StringLength(DbFiledConsts.DefaultLength)]
        public string ClaimType { get; set; }

        /// <summary>
        /// 声明值类型
        /// </summary>
        [StringLength(DbFiledConsts.DefaultLength)]
        public string ClaimValueType { get; set; }

        /// <summary>
        /// 声明值
        /// </summary>
        public string ClaimValue { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTimeOffset CreateDateTime { get; set; }
    }
}
