using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ClassDisable.Utils
{
	public class DamageClassDictionary<T>: IEnumerable
	{
		private Dictionary<DamageClass, string> DamageClassToString { get; } = new();

		private Dictionary<string, T> Dict { get; } = new();

		public void Set(DamageClass damageClass, T val)
		{
			DamageClassToString.TryAdd(damageClass, damageClass.DisplayName);
			if (!Dict.TryAdd(damageClass.DisplayName, val))
			{
				Dict[damageClass.DisplayName] = val;
			};
		}

		public void Set(string damageClass, T val)
		{
			if (!Dict.TryAdd(damageClass, val))
			{
				Dict[damageClass] = val;
			};
		}

		public T Get(DamageClass damageClass)
		{
			DamageClassToString.TryAdd(damageClass, damageClass.DisplayName);
			return Dict[damageClass.DisplayName];
		}

		public TagCompound Serialize()
		{
			TagCompound tag = new();
			foreach (KeyValuePair<string, T> pair in Dict)
			{
				tag[pair.Key] = pair.Value;
			}
			return tag;
		}

		public IEnumerator GetEnumerator()
		{
			foreach (KeyValuePair<DamageClass, string> pair in DamageClassToString) {
				yield return new KeyValuePair<DamageClass, T>(pair.Key, Dict[pair.Value]);
			}
		}
	}
}
