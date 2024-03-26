




public abstract class EmployeeBuilderM2:IEmployeeBuilderM2
{
    protected EmployeeM2 Employee{get;set;}

    public EmployeeBuilderM2()
    {
        Employee=new EmployeeM2();
    }

    public abstract void SetFullName(string fullName);

    public abstract void SetEmailAddress(string emailAdsress);

    public abstract void SetUserName(string username);

    public EmployeeM2 BuildEmployee()=>Employee;

}

public interface IEmployeeBuilderM2
{
    EmployeeM2 BuildEmployee();
    void SetEmailAddress(string emailAdsress);

    void SetFullName(string fullName);

    void SetUserName(string username);
}
