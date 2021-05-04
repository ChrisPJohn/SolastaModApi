<Query Kind="Program" />

readonly string installDir = @"D:\Program Files (x86)\SteamLibrary\steamapps\common\Slasta_COTM_0_5_42";

void Main()
{
	bool parseAssets = true;
	
	// Read assets.txt and show assets that are stored in multiple databases
	if (parseAssets)
	{
		File.ReadLines(@"C:\Users\passp\source\repos\SolastaModApi\Scripts\Assets.txt")
			.Skip(1)
			.Select(f => f.Split("\t"))
			.Select(f => new { Name = f[0], Type = f[1], Database = f[2], Guid = f[3] })
			.GroupBy(f => new { f.Name, f.Type })
			.Select(g => new
			{
				g.Key.Type,
				g.Key.Name,
				DatabaseList = string.Join(", ", g.Select(x => x.Database).OrderBy(x => x))
			})
			.GroupBy(g => g.DatabaseList)
			.Where(g => g.Any(x => x.Type != x.DatabaseList))
			.Dump();
	}

	var assemblyDir = Path.Combine(installDir, @"Solasta_Data\Managed");
	var assembly = Assembly.LoadFrom(Path.Combine(assemblyDir, @"Assembly-CSharp.dll"));

// Types with these base classes are stored in multiple dbs:

// FeatureDefinition
// BasebluePrint
// EditableGraphDefinition
// RecordTableDefinition

// quick and dirty code generation

	var types = GetDerivedTypes(assembly, "RecordTableDefinition");
	//types.Dump();
	
	var sb = new StringBuilder();
	foreach(var t in types.Select(t => t.type))
	{
		sb.Append($"if (Definition is {t.Name}) {{ AddToDB(Definition as {t.Name}, assertIfDuplicate); }}{Environment.NewLine}");	
	}
	
	sb.ToString().Dump("");
}


IEnumerable<(Type type, Type baseType)> GetDerivedTypes(Assembly assembly, string baseType)
{
	var types = assembly.GetTypes().ToList();
	
	var type = types.SingleOrDefault(t => t.Name == baseType);
	
	if(type == null)
	{
		return Enumerable.Empty<(Type type, Type baseType)>();
	}

	return Enumerable
		.Repeat((type, (Type)null), 1)
		.Concat(GetDerivedTypes(assembly, type));
}

IEnumerable<(Type type, Type baseType)> GetDerivedTypes(Assembly assembly, Type baseType)
{
	var types = assembly.GetTypes()
		.Where(t => t.BaseType?.Name == baseType.Name)
		.Select(t => (type: t, baseType))
		.OrderBy(t => t.type.Name)
		.ToList();

	return types.Concat(types.SelectMany(t => GetDerivedTypes(assembly, t.type)));
}
