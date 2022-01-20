using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using JellyStaticBlazor.Common.Models;

namespace JellyStaticBlazor.API.Data
{
    public class PersonsManager
    {
		public List<Person> People { get; set; }
        
		public PersonsManager()
		{
			string filename = $"{Environment.CurrentDirectory}\\people.json";
			if (File.Exists(filename))
			{
				string json = File.ReadAllText(filename);
				People = JsonSerializer.Deserialize<List<Person>>(json);
			}
		}
    }
}
