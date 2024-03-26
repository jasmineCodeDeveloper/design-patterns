// namespace DesignPattern.BuilderPattern;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");
//     }
// }

using System.Text;

var sb=new StringBuilder();

sb.Append("yasemin").Append(" ").Append("elvan");
sb.Append("elvan");

var fullname=sb.ToString();


var eb=new EndpointBuilder("https://localhost");

eb
.Append("api")
.Append("v1")
.Append("user")
.AppendParam("id","5")
.AppendParam("username","yasemin");

var url=eb.Build();

//System.Console.WriteLine("Final url:"+url);

var empBuilder=new EmployeeBuilderM1();
var employee=empBuilder
.SetFullName("yasemin elvan")
.SetUserName("yaseminelvan")
.SetEmailAddress("yaseminelvanqgamil.com")
.BuildEmployee();

//System.Console.WriteLine("M1 Employee FirstName:"+employee.FirstName);



var emp=GenerateEmployee("yasmin elvan","yaseminelvan@gmail.com",0);
System.Console.WriteLine("Email Address: "+emp.EmailAdsress);
/*IEmployeeBuilderM2 employeeBuilder=new InternalEmployeeBuilder();

employeeBuilder.SetEmailAddress("yaseminelvan@gmail.com");
employeeBuilder.SetFullName("Yasemin Elvan");
var emp=employeeBuilder.BuildEmployee();

System.Console.WriteLine("Email Address: "+emp.EmailAdsress);*/


EmployeeM2 GenerateEmployee(string fullName,string emailAdsress,int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if(empType==0)
    employeeBuilder=new InternalEmployeeBuilder();
    else
    employeeBuilder=new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAdsress);
    return employeeBuilder.BuildEmployee();

}