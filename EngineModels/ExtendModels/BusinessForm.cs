using System.ComponentModel.DataAnnotations;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public record FieldItem(string Key, string Name, string Value);

    public record JsonBusiness(List<FieldItem> FieldItems);

    public class BusinessForm : BusinessBase
    {
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


        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 格式化的标题
        /// </summary>
        public string TitleFormat { get; set; }

        /// <summary>
        /// 拟稿人（固定不变）  用户名
        /// </summary>
        public string DrafterUserName { get; set; }


        /// <summary>
        /// 拟稿人（固定不变）  用户名
        /// </summary>
        public string DrafterName { get; set; }


        /// <summary>
        /// 拟稿人所在部门（系统自动填充） 
        /// </summary>
        public string DrafterDepartment { get; set; }

        /// <summary>
        /// 办理期限
        /// </summary>
        public DateTime? MaxDueEndDateTime { get; set; }


        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// 最后编辑者
        /// </summary>
        public string LastEditorUserName { get; set; }

        /// <summary>
        /// 最后一次编辑时间
        /// </summary>
        public DateTime? LastEditDateTime { get; set; }

        /// <summary>
        /// 自定义编号1
        /// </summary>
        [MaxLength(256)]
        public string CustomNumber1 { get; set; }

        /// <summary>
        /// 自定义编号2
        /// </summary>
        [MaxLength(256)]
        public string CustomNumber2 { get; set; }

        /// <summary>
        /// 自定义编号3
        /// </summary>
        [MaxLength(256)]
        public string CustomNumber3 { get; set; }

        /// <summary>
        /// 自定义标记
        /// </summary>
        [MaxLength(256)]
        public string Tag { get; set; }


        /// <summary>
        /// 是否隐藏表单，隐藏后不显示出来
        /// </summary>
        public bool? Hidden { get; set; }
    }
}
