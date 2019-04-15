// First approach to persistence

using System.IO;

class Person
{
    private string name;
    private int age;

    public string GetName() { return name; }
    public void SetName(string n) { name = n;  }

    public int GetAge() { return age; }
    public void SetAge(int a) { age = a; }

    public void Save(string fileName)
    {
        BinaryWriter outputFile = new BinaryWriter(
            File.Open(fileName, FileMode.Create));
        outputFile.Write(name);
        outputFile.Write(age);
        outputFile.Close();
    }

    public void Load(string fileName)
    {
        BinaryReader inputFile = new BinaryReader(
            File.Open(fileName, FileMode.Open));
        name = inputFile.ReadString();
        age = inputFile.ReadInt32();
        inputFile.Close();
    }
}

class PersonTest
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.SetName("Yo");
        p.SetAge(20);
        System.Console.WriteLine(p.GetName()+" "+p.GetAge());
        p.Save("person1.dat");

        p.SetName("Tu");
        p.SetAge(21);
        System.Console.WriteLine(p.GetName() + " " + p.GetAge());

        p.Load("person1.dat");
        System.Console.WriteLine(p.GetName() + " " + p.GetAge());


    }
}

