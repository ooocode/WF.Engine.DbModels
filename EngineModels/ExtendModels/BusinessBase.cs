using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using WF.Engine.DbModels.Consts;

namespace WF.Engine.DbModels.EngineModels.ExtendModels
{
    public abstract class BusinessBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusinessKey { get; set; }

        /// <summary>
        /// 外部系统业务编号
        /// </summary>
        [MaxLength(512)]
        public string ExternalSystemBusinessKey { get; set; }


        /// <summary>
        /// 外部系统显示部门
        /// </summary>
        public string ExternalSystemDepartment { get; set; }


        [Column(TypeName = "xml")]
        public string XmlFields { get; set; }


        //[Column(TypeName = "jsonb")]
        //public FormFields FormFields { get; set; }

        public void SetBusinessField(string key, string name, object value)
        {
            if (value is null)
            {
                return;
            }

            XElement root;
            if (string.IsNullOrEmpty(XmlFields))
            {
                root = new XElement("BusinessFields");
            }
            else
            {
                root = XElement.Parse(XmlFields);
            }

            XElement element = root.Descendants(FormConst.Field).FirstOrDefault(e => e.Attribute(FormConst.Key)?.Value == key);
            if (element == null)
            {
                element = new XElement(FormConst.Field);
                root.Add(element);
            }

            element.SetAttributeValue(FormConst.Key, key);
            if (!string.IsNullOrEmpty(name))
            {
                element.SetAttributeValue(FormConst.Name, name);
            }

            try
            {
                var children = XElement.Parse(value.ToString());
                element.Descendants().Remove();
                element.Add(children);
            }
            catch (Exception)
            {
                element.SetValue(value);
            }

            XmlFields = root.ToString();
        }

        public void SetBusinessField(string key, object value)
        {
            SetBusinessField(key, null, value);
        }

        [NotMapped]
        public List<FieldItem> FieldItems { get; set; }

        public IEnumerable<FieldItem> GetFields()
        {
            if (!string.IsNullOrEmpty(XmlFields))
            {
                var root = XElement.Parse(XmlFields);
                var fields = root.Descendants(FormConst.Field);
                foreach (var item in fields)
                {
                    yield return new FieldItem(item.Attribute(FormConst.Key)?.Value, item.Attribute(FormConst.Name)?.Value, item.Value);
                }
            }
        }

        public string GetField(string key)
        {
            key = key.ToUpper();
            return GetFields().FirstOrDefault(e => e.Key.ToUpper() == key)?.Value;
        }
    }

    public class FormFields
    {
        public List<FormField> Fields { get; set; }
    }

    /// <summary>
    /// 表单字段
    /// </summary>
    public class FormField
    {
        public FormField()
        {

        }

        public FormField(string key, string displayName, string value)
        {
            Key = key;
            DisplayName = displayName;
            Value = value;
        }

        public FormField(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }
}
