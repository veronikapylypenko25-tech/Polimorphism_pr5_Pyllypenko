namespace Polimorphism_pr5_Pylypenko_Veronika;

public class UniversityMember
{
    private string _name;

    public string Name
    {
        get=>_name;
        set=>_name=string.IsNullOrEmpty(value)? throw new Exception("Name cannot be empty!"):value;
    }
    public string MemberID { get; private set; }
    protected List<string> ActionLog = new List<string>();

    public UniversityMember(string name, string id)
    {
        Name = name;
        MemberID = id;
    }

    virtual void PerformDuties()
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("Member has already reached a daily limit of 5 actions!");
        }
        ActionLog.Add("Duty performed");
    }
}