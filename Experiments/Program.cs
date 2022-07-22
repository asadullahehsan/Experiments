using Experiments;
using System.Text.Json;

string str = "{\"Id\": 101, \"Name\": \"IT\"}";
 Department department = JsonSerializer.Deserialize<Department>(str)!;
Console.WriteLine($"{department.Id}: {department.Name}");