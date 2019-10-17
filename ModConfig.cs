using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenRAModEditor
{
	public class ModConfig
	{
		private Dictionary<string, string> itemValuePairs;

		public Dictionary<string, string> ItemValuePairs
		{
			get
			{
				return itemValuePairs;
			}
		}

		public string this[string key]
		{
			get
			{
				if (itemValuePairs.ContainsKey(key))
				{
					return itemValuePairs[key];
				}
				else
				{
					return null;
				}
			}
			set
			{
				if (itemValuePairs.ContainsKey(key))
				{
					itemValuePairs[key] = value;
				}
			}
		}

		public ModConfig()
		{
			itemValuePairs = new Dictionary<string, string>();
		}

		public void AppendItemValue(string item, string value)
		{
			if (!itemValuePairs.ContainsKey(item))
			{
				itemValuePairs.Add(item, value);
			}
		}
	}
}