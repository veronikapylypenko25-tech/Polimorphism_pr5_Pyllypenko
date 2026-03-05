namespace Polimorphism_pr5_Pylypenko_Veronika;

public class GraduateStudent : UndergraduateStudent
{
    public   GraduateStudent(string name, string id) : base(name, id)
    {
        
    }
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Thesis research update");
    }
}