using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    /// <summary>
    /// 附件
    /// </summary>
    public class FormAttachment
    {
        /// <summary>
        /// Id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 创建者用户名
        /// </summary>
        [Required]
        public string CreatorUserName { get; set; }


        /// <summary>
        /// 唯一业务编号
        /// </summary>
        [Required]
        public string BusinessKey { get; set; }


        /// <summary>
        /// 原始文件名称
        /// </summary>
        [Required]
        public string OrignFileName { get; set; }


        /// <summary>
        /// 当前文件名称
        /// </summary>
        [Required]
        public string FileName { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [Required]
        public string ContentType { get; set; }

        /// <summary>
        /// 文件字节长度
        /// </summary>
        public long BytesLength { get; set; }

        /// <summary>
        /// 创建日期（第一次上传的时间）
        /// </summary>
        public DateTimeOffset CreateDateTime { get; set; }


        /// <summary>
        /// 最新的上传时间
        /// </summary>
        public DateTimeOffset LastUploadDateTime { get; set; }

        /// <summary>
        /// 最新的更新者，谁最后修改了这个文件
        /// </summary>
        public string LastUploadUserName { get; set; }

        /// <summary>
        /// 显示的排序
        /// </summary>
        public int Order { get; set; }

        [ConcurrencyCheck]
        public int RowVersion { get; set; }

        /// <summary>
        /// 自定义标记
        /// </summary>
        [MaxLength(256)]
        public string Tag { get; set; }

        /// <summary>
        /// 附件不允许删除
        /// </summary>
        public bool? NotAllowedDelete { get; set; }

        /// <summary>
        /// 是否隐藏附件，隐藏后不显示出来
        /// </summary>
        public bool? Hidden { get; set; }
    }
}
