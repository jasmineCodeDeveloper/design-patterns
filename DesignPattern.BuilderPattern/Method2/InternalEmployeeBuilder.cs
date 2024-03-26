public class InternalEmployeeBuilder : EmployeeBuilderM2
{
    public override void SetEmailAddress(string emailAdsress)
    {
        var arr=emailAdsress.Split("@");
        //endwith @company.com.tr
        Employee.EmailAdsress=arr[0]+"@company.com.tr";
    }

    public override void SetFullName(string fullName)
    {
        var arr=fullName.Split(new[]{' ','_','.'});
        Employee.FirstName=arr[0];
        Employee.LastName=arr[1];
    }

    public override void SetUserName(string username)
    {
        throw new NotImplementedException();
    }
}