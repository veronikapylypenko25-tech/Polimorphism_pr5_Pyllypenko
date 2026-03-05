namespace Polimorphism_pr5_Pylypenko_Veronika;

public class UndergraduateStudent : UniversityMember
{
    public  UndergraduateStudent(string name, string id) : base(name, id)
    {
        
    }
    public override void PerformDuties()
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("Member has already reached a daily limit of 5 actions!");
        }
        ActionLog.Add("Lab work completed");
    }
}