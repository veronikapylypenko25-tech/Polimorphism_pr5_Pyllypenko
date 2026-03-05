namespace Polimorphism_pr5_Pylypenko_Veronika;

class Program
{
    static void Main(string[] args)
    {
        UniversityRegistry registry = new UniversityRegistry();
        Proffesor proffesor = new Proffesor("Dr. Meier", "10K");
        UndergraduateStudent undergraduate = new UndergraduateStudent("Nika", "11M");
        GraduateStudent graduate = new GraduateStudent("Kira", "12N");
        registry.AddMember(proffesor);
        registry.AddMember(undergraduate);
        registry.AddMember(graduate);
        registry.ExecuteAllDuties();
        proffesor.ConductResearch("OOP");
        Console.WriteLine("Total actions: "+ registry.GetMemberStatistics());
    }
}