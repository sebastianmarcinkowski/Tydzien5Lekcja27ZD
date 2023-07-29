using Newtonsoft.Json;
using System;
using System.IO;

namespace Tydzien5Lekcja27ZD
{
	public class JSONFileHelper<T> where T : new()
	{
		private string _filePath;

		public JSONFileHelper(string filePath)
		{
			_filePath = filePath;
		}

		public void SerializeToFile(T obj)
		{
			var json = JsonConvert.SerializeObject(obj);

			File.WriteAllText(_filePath, json);
		}

		public T DeserializeFromFile()
		{
			if (!File.Exists(_filePath))
			{
				return new T();
			}

			var json = File.ReadAllText(_filePath);

			if (JsonConvert.DeserializeObject<T>(json) == null)
				throw new Exception("DBIsDamaged");

			return JsonConvert.DeserializeObject<T>(json);
		}
	}
}
