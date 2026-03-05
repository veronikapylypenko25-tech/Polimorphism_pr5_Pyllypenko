namespace Polimorphism_pr5_Pylypenko_Veronika;

public class Proffesor:UniversityMember
{
    public Professor(string name, string id) : base(name, id)
    {
        
    }
    public override void PerformedDuties()
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("Member has already reached a daily limit of 5 actions!");
        }
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        if (ActionLog.Count >= 5)
        {
            throw new Exception("Member has already reached a daily limit of 5 actions!");
        }
        ActionLog.Add("Research conducted on "+topic);
    }
}