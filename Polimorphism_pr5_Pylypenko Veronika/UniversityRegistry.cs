namespace Polimorphism_pr5_Pylypenko_Veronika;

public class UniversityRegistry
{
    private List<UniversityMember> _members=new List<UniversityMember>();

    public void AddMember(UniversityMember m)
    {
        _members.Add(m);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in _members)
        {
            member.PerformDuties();
        }
    }

    public int GetMemberStatistics()
    {
        int totalActions = 0;
        foreach (var member in _members)
        {
            totalActions += member.GetActionCount();
        }
        return totalActions;
    }
}