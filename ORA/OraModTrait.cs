using OpenRAModEditor.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor.ORA
{
	public class OraModTrait
	{
		private string name;
		private string modID;
		private List<OraModTraitParameter> paramList;

		public string Name
		{
			get
			{
				return name;
			}
		}

		public string ModID
		{
			get
			{
				return modID;
			}
		}
		public List<OraModTraitParameter> ParamList
		{
			get
			{
				return paramList;
			}
		}

		public OraModTrait(string name, string modID)
		{
			this.name = name;
			this.modID = modID;
			paramList = new List<OraModTraitParameter>();
		}

		public void AddParam(OraModTraitParameter param)
		{
			paramList.Add(param);
		}

		public void Serialize()
		{

		}

		public void Deserialize()
		{

		}
	}

	public class OraModTraitParameter
	{
		private string name;
		private string description;
		private IOraModTraitParamSupportType supportedType;

		public string Name
		{
			get
			{
				return name;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
		}

		public object Value
		{
			get
			{
				return supportedType.Value;
			}
		}
		public OraModTraitParameter(string name, string description, IOraModTraitParamSupportType supportedType)
		{
			this.name = name;
			this.description = description;
			this.supportedType = supportedType;
			supportedType.SetParamName(name);
		}
	}

	public interface IOraModTraitParamSupportType
	{
		string Name { get; }
		Type Type { get; }
		object Value { get; }
		void OpenEditor();
		void SetParamName(string paramName);
	}

	public class OraModTraitParamSupportTypeSingleValue : IOraModTraitParamSupportType
	{
		private string paramName;
		private string value;
		public string Name
		{
			get
			{
				return "SingleValue";
			}
		}

		public Type Type { get { return typeof(string); } }

		public object Value
		{
			get
			{
				return value;
			}
		}

		public void OpenEditor()
		{
			frmSingleValueEditor singleValueEditor = new frmSingleValueEditor(paramName);
			if (singleValueEditor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				value = singleValueEditor.Value;
			}
		}

		public void SetParamName(string paramName)
		{
			this.paramName = paramName;
		}
	}
}
