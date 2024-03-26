public class EmployeeBuilderM1
{

    private EmployeeM1 employee { get; set; }
    public EmployeeBuilderM1()
    {
        employee=new EmployeeM1();
    }


    public EmployeeBuilderM1 SetFullName(string fullName)
    {
        var arr=fullName.Split(' ');
        employee.FirstName=arr[0];
        employee.LastName=arr[1];
        return this;
    } 
    public EmployeeBuilderM1 SetEmailAddress(string emailAdsress)
    {
        //email validation
        employee.EmailAdsress=emailAdsress;
        return this;
    }


    //username validation
    public EmployeeBuilderM1 SetUserName(string UserName)
    {
        employee.UserName=UserName;
        return this;

    }


    public EmployeeM1 BuildEmployee()
    {
        return employee;
    }

}