using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OpenCvSharpPT.Control
{
    /// <summary>
    /// 커스텀 페어 어레이 속성
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CustomPairs
    {
        private string mstr_Name = "";
        private string mstr_Value = "";

        public CustomPairs(): this(string.Empty, string.Empty)
        {

        }
        public CustomPairs(string name, string value)
        {
            mstr_Name = name;
            mstr_Value = value;
        }

        //get / set Property
        [Category("Behavior")]
        [DefaultValue("")]
        [Description("명칭 설정")]
        [NotifyParentProperty(true)]
        public string Name
        {
            get
            {
                return mstr_Name;
            }
            set
            {
                mstr_Name = value;
            }
        }
        [Category("Behavior")]
        [DefaultValue("")]
        [Description("값 설정")]
        [NotifyParentProperty(true)]
        public string Value
        {
            get
            {
                return mstr_Value;
            }
            set
            {
                mstr_Value = value;
            }
        }

    }
    /// <summary>
    /// 커스텀 필드 어레이 속성
    /// </summary>
    /// 
    public class CustinFields
    {
        private string mstr_FieldName = "";
        private string mstr_HeaderText = "";
        private bool mbol_Visible = true;

        public CustinFields() : this(string.Empty, string.Empty, true)
        {

        }

        public CustinFields(string fieldName, string headerText, bool visible)
        {
            mstr_FieldName = fieldName;
            mstr_HeaderText = headerText;
            mbol_Visible = visible;
        }
        [Category("Behavior")]
        [DefaultValue("")]
        [Description("필드 명칭 설정")]
        [NotifyParentProperty(true)]
        public string FieldName
        {
            get
            {
                return mstr_FieldName;
            }
            set
            {
                mstr_FieldName = value;
            }
        }
        [Category("Behavior")]
        [DefaultValue("")]
        [Description("필드 명칭 설정")]
        [NotifyParentProperty(true)]
        public string HeaderText
        {
            get
            {
                return mstr_HeaderText;
            }
            set
            {
                mstr_HeaderText = value;
            }
        }

        [Category("Behavior")]
        [DefaultValue(true)]
        [Description("보이기 설정")]
        [NotifyParentProperty(true)]
        public bool Visible
        {
            get
            {
                return mbol_Visible;
            }
            set
            {
                mbol_Visible = value;
            }
        }
    }

}
