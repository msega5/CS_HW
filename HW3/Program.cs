namespace Seminar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var father = new AdultFamilyMember() { Mother = null, Father = null, Name = "Bob", Sex = Gender.Male };
            var mother = new AdultFamilyMember() { Mother = null, Father = null, Name = "Olga", Sex = Gender.Female };
            
            var son = new FamilyMember() { Father = father, Mother = mother, Name = "Nill", Sex = Gender.Male };

            mother.Pares = new FamilyMember[] { father };
            father.Pares = new FamilyMember[] { mother };

            mother.Print(1);
            father.Print();
            Console.ReadLine();
        }
    }
}
