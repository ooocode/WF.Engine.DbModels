using System.ComponentModel.DataAnnotations;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public class OpinionType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 处理定义key
        /// </summary>
        [Required]
        public string ProcessDefKey { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        public string Name { get; set; }


        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 在哪些活动节点状态下可输入意见
        /// </summary>
        public string AllowEditOnActvities { get; set; }

        /// <summary>
        /// 意见按钮，如 已阅  无修改意见.....
        /// </summary>
        public string OpinionButtons { get; set; }

        /// <summary>
        /// 完成按钮 如 签发完成   
        /// </summary>
        public string CompleteButton { get; set; }


        /// <summary>
        /// 是否一键直接完成（比如局领导想直接点击按钮即完成）
        /// </summary>
        public bool IsDirectedComplete { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool Enabled { get; set; }
    }
}
