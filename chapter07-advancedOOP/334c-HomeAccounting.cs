using System;

class BaseTransaction
{
    public byte Day { get; set; }
    public byte Month { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }

    public BaseTransaction(byte day, byte month, 
        double amount, string description)
    {
        this.Day = day;
        this.Month = month;
        this.Amount = amount;
        this.Description = description;
    }
    
    public override string ToString()
    {
        return Day.ToString("00") + "/" + Month.ToString("00")
            + "  " + Description + " (" + Amount +")";
    }
}

// ------------------------------------

class Transaction: BaseTransaction
{
    public short Year { get; set; }

    public Transaction(byte day, byte month, short year, 
            double amount, string description) 
        : base(day, month, amount, description)
        
    {
        this.Year = year;
    }
    
    public override string ToString()
    {
        return Day.ToString("00") + "/" + Month.ToString("00")
            + "/" + Year.ToString("00")
            + "  " + Description + " (" + Amount +")";
    }
}

// ------------------------------------

class RepetitiveTransaction : BaseTransaction
{

    public RepetitiveTransaction(byte day, byte month,
            double amount, string description) 
        : base( day, month, amount, description)
    {
    }
    
    public override string ToString()
    {
        return base.ToString() + " [R]";
    }
}

// ------------------------------------

class TransactionList
{
    private int amountOfTransactions;
    private BaseTransaction[] Transactions;
    
    public TransactionList()
    {
        Transactions = new BaseTransaction[1000];
        this.amountOfTransactions = 0;
    }
    
    public void Add(BaseTransaction t)
    {
        Transactions[amountOfTransactions] = t;
        amountOfTransactions++;
    }
    
    public int GetLength()
    {
        return amountOfTransactions;
    }
    
    public BaseTransaction GetTransaction(int i)
    {
        return Transactions[i];
    }
}

// ------------------------------------

class HomeAccounting
{
    static void Main(string[] args)
    {
        TransactionList tList = new TransactionList();
        TransactionList rList = new TransactionList();

        bool finished = false;

        do
        {
            Console.WriteLine("1- Add transaction");
            Console.WriteLine("2- Add repetitive transaction");
            Console.WriteLine("3- Show transactions in a month");
            Console.WriteLine("4- Search by text");
            Console.WriteLine("Q- Quit");
        
            switch (Console.ReadLine()[0])
            {
                case '1': // 1- Add transaction
                    Console.WriteLine("Day: ");
                    byte day = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Month: ");
                    byte month = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Year: ");
                    short year = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Description: ");
                    string description = Console.ReadLine();

                    tList.Add( new Transaction(day, month, year, 
                        amount, description));
                    break;

                case '2': // 2- Add repetitive transaction
                    Console.WriteLine("Day: ");
                    byte rday = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Month: ");
                    byte rmonth = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Amount: ");
                    double ramount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Description: ");
                    string rdescription = Console.ReadLine();

                    rList.Add( new RepetitiveTransaction (rday, rmonth, 
                        ramount, rdescription));
                    break;

                case '3': // 3- Show transactions in a month
                    Console.WriteLine("Month: ");
                    byte sMonth = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Year: ");
                    byte sYear = Convert.ToByte(Console.ReadLine());

                    for (int i = 0; i < tList.GetLength(); i++)
                    {
                        Transaction t = (Transaction) tList.GetTransaction(i);
                        if (t.Month == sMonth && t.Year == sYear)
                            Console.WriteLine(tList.GetTransaction(i));
                    }
                    
                    for (int i = 0; i < rList.GetLength(); i++)
                    {
                        RepetitiveTransaction t = 
                            (RepetitiveTransaction) rList.GetTransaction(i);
                        if (t.Month == sMonth)
                            Console.WriteLine(rList.GetTransaction(i));
                    }
                    break;

                case '4':
                    Console.WriteLine("Enter text to search: ");
                    string search = Console.ReadLine();

                    for (int i = 0; i < tList.GetLength(); i++)
                    {
                        if(tList.GetTransaction(i).ToString().Contains(search))
                            Console.WriteLine(tList.GetTransaction(i));
                    }
                    for (int i = 0; i < rList.GetLength(); i++)
                    {
                        if(rList.GetTransaction(i).ToString().Contains(search))
                            Console.WriteLine(rList.GetTransaction(i));
                    }
                    break;

                case 'q': 
                case 'Q': 
                    finished = true;
                    break;
            }
        } while (!finished);
    }
}

