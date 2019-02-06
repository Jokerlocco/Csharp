//Sergio Ruescas
using System;

class Person
{
    protected string surnameAndName;
    protected int code;

    public Person(string surnameAndName, int code)
    {
        SetSurnameAndName(surnameAndName);
        SetCode(code);
    }

    public void SetSurnameAndName(string surnameAndName)
    {
        this.surnameAndName = surnameAndName;
    }

    public void SetCode(int code)
    {
        this.code = code;
    }

    public string GetSurnameAndName()
    {
        return surnameAndName;
    }

    public int GetCode()
    {
        return code;
    }

    public override string ToString()
    {
        return "Surname And Name: " + surnameAndName + " Code: " + code;
    }
}

class Doctor : Person
{
    protected string specialty;

    public Doctor(string surnameAndName, int code) 
        : base(surnameAndName, code)
    {
        SetSpecialty("General Medicine");
    }

    public Doctor(string specialty, string surnameAndName, int code) 
        : base(surnameAndName, code)
    {
        SetSpecialty(specialty);
    }

    public void SetSpecialty(string specialty)
    {
        this.specialty = specialty;
    }

    public string GetSpecialty()
    {
        return specialty;
    }

    public override string ToString()
    {
        return base.ToString() + " Specialty: " + specialty;
    }
}

class Patient : Person
{
    public Patient(string surnameAndName, int code) 
        : base(surnameAndName, code)
    {
    }
}

class Nurse : Person
{
    public Nurse(string surnameAndName, int code) 
        : base(surnameAndName, code)
    {
    }
}

abstract class Consultation
{
    protected Patient Pat { set; get; }
    protected Doctor Doc { set; get; }
    protected DateTime Date { set; get; }
    protected string Reason { set; get; }
    protected string Diagnostic { set; get; }

    public Consultation(Patient Pat, Doctor Doc, DateTime Date,
        string Reason, string Diagnostic)
    {
        this.Pat = Pat;
        this.Doc = Doc;
        this.Date = Date;
        this.Reason = Reason;
        this.Diagnostic = Diagnostic;
    }

    public override string ToString()
    {
        return Pat.GetSurnameAndName() + " - "
            + Doc.GetSurnameAndName() + " - " + Date +
            " - " + Reason + " - " + Diagnostic;
    }
}


class Emergency : Consultation
{
    protected bool NeedOtherConsultation { set; get; }

    public Emergency(bool NeedOtherConsultation, Patient Pat, 
        Doctor Doc, DateTime Date, string Reason, string Diagnostic)
        : base(Pat, Doc, Date, Reason, Diagnostic)
    {
        this.NeedOtherConsultation = NeedOtherConsultation;
    }

    public override string ToString()
    {
        if (NeedOtherConsultation)
            return "Urgency -" + base.ToString() + " (P)";
        else
            return "Urgency - " + base.ToString();
    }
}


class PlannedConsultation : Consultation
{
    public PlannedConsultation(Patient Pat, Doctor Doc, DateTime Date, 
        string Reason, string Diagnostic)
        : base(Pat, Doc, Date, Reason, Diagnostic)
    {
    }

    public override string ToString()
    {
        return "Planned - " + base.ToString() + " (P)";
    }
}


class Office
{
    public void Run()
    {
        const int SIZE = 1000;
        string input = "", surnameAndName, consultationType, diagnostic, reason;
        bool needOtherConsultation, existPatient, existDoctor;
        int countPatient = 0, countConsultation = 0, codePatient, codeDoctor;
        Doctor doc1 = new Doctor("Arroyo Garcia, Antonio", 1234);
        Doctor doc2 = new Doctor("Rojas Sancher, Manuel", 4321);
        Nurse nurse = new Nurse("Sanchez, Rick", 666);
        Patient[] patients = new Patient[SIZE];
        Consultation[] consultations = new Consultation[SIZE];
        Patient p = new Patient("", -1);
        Doctor d = new Doctor("", -1);

        do
        {
            Console.WriteLine("1. Add a patient");
            Console.WriteLine("2. Search a patient by name");
            Console.WriteLine("3. Add a consultation");
            Console.WriteLine("4. Show consultations");
            Console.WriteLine("X. Exit");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Surname and Name: ");
                    surnameAndName = Console.ReadLine();
                    Console.Write("Code: ");
                    codePatient = Convert.ToInt32(Console.ReadLine());
                    patients[countPatient] = new Patient(surnameAndName, codePatient);
                    countPatient++;
                    break;

                case "2":
                    Console.Write("Enter part of the name or surname: ");
                    surnameAndName = Console.ReadLine();
                    for (int i = 0; i < countPatient; i++)
                    {
                        if (patients[i].ToString().ToUpper().
                                Contains(surnameAndName.ToUpper()))
                        {
                            Console.WriteLine(patients[i].ToString());
                        }
                    }
                    break;

                case "3":
                    existPatient = false;
                    existDoctor = false;
                    Console.Write("Consultation type: ");
                    consultationType = Console.ReadLine();
                    do
                    {
                        Console.Write("Patient code: ");
                        codePatient = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < countPatient; i++)
                        {
                            if (patients[i].GetCode() == codePatient)
                            {
                                p = patients[i];
                                existPatient = true;
                            }
                        }

                        if (existPatient == false)
                            Console.WriteLine("Incorrect code.");

                    } while (existPatient == false);

                    do
                    {
                        Console.Write("Doctor code: ");
                        codeDoctor = Convert.ToInt32(Console.ReadLine());

                        if (codeDoctor == doc1.GetCode())
                        {
                            d = doc1;
                            existDoctor = true;
                        }
                        else if (codeDoctor == doc2.GetCode())
                        {
                            d = doc2;
                            existDoctor = true;
                        }
                        else
                            Console.WriteLine("Incorrect code.");

                    } while (existDoctor == false);

                    Console.WriteLine("Reason of the consultation: ");
                    reason = Console.ReadLine();
                    Console.WriteLine("Diagnostic: ");
                    diagnostic = Console.ReadLine();

                    if (consultationType == "Urgency")
                    {
                        Console.WriteLine("Need other consultation (Y/N): ");
                        needOtherConsultation = Convert.ToBoolean(Console.ReadLine() == "Y" ? true : false);
                        consultations[countConsultation] = new Emergency(needOtherConsultation, p, d, DateTime.Now, reason, diagnostic);
                    }
                    else
                    {
                        consultations[countConsultation] = new PlannedConsultation(p, d, DateTime.Now, reason, diagnostic);
                    }
                    countConsultation++;
                    break;

                case "4":
                    for (int i = 0; i < countConsultation; i++)
                    {
                        Console.WriteLine(consultations[i].ToString());
                    }
                    break;
            }
        } while (input != "X");
    }

    public static void Main()
    {
        Office office = new Office();
        office.Run();
    }
}
