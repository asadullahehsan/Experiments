using Experiments;
using System.Text.Json;

string jsonArray = "{\"Id\": 101, \"Name\": \"IT\"}";
Department department = JsonSerializer.Deserialize<Department>(jsonArray)!;
Console.WriteLine($"{department.Id}: {department.Name}");

//string jsonArray = "[{\"Id\": 101,\"Name\":\"IT\" }, {\"Id\": 102,\"Name\":\"Accounts\" }]";
//var deptList = JsonSerializer.Deserialize<IList<Department>>(jsonArray);

//foreach (var dept in deptList!)
//{
//    Console.WriteLine("Department Id is: {0}", dept.Id);
//    Console.WriteLine("Department Name is: {0}", dept.Name);
//}
