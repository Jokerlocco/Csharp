// Sergio Ruescas, Jorge Calzada y José Vicente Antón

using System;

class Transaction
{
    protected byte day;
    protected byte month;
    protected short year;
    public int Amount { get; set; }
    public string Description { get; set; }

    public Transaction(int day, int month, int year, int amount,
    string description)
    {
        Day = day;
        Month = month;
        Year = year;
        Amount = amount;
        Description = description;
    }

    public int Day
    {
        get
        {
            return day;
        }
        set
        {
            day = (byte)value;
        }
    }

    public int Month
    {
        get
        {
            return month;
        }
        set
        {
            month = (byte)value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = (short)value;
        }
    }

    public override string ToString()
    {
        return "Transaction: date = " + Month + "-" + Day + "-" + Year +
        "; amount = " + Amount + "; description = " + Description;
    }
}

// ----------------------------------


class TransactionList
{
    public Transaction[] Transactions { set; get; }
    protected int position = 0;

    public void Add(Transaction transaction)
    {
        Transactions[position] = transaction;
        position++;
    }

    public int GetLength()
    {
        return position;
    }

    public string GetTransaction(int i)
    {
        return Transactions[i].ToString();
    }

}

// ----------------------------------

class RepetitiveTransaction
{
    protected byte day;
    protected byte month;
    public int Amount { get; set; }
    public string Description { get; set; }

    public RepetitiveTransaction(int day, int month, int amount,
    string description)
    {
        Day = day;
        Month = month;
        Amount = amount;
        Description = description;
    }

    public int Day
    {
        get
        {
            return day;
        }
        set
        {
            day = (byte)value;
        }
    }

    public int Month
    {
        get
        {
            return month;
        }
        set
        {
            month = (byte)value;
        }
    }

    public override string ToString()
    {
        return "Transaction: date = " + Month + "-" + Day + "; amount = " +
        Amount + "; description = " + Description;
    }
}

// ----------------------------------

class RepetitiveTransactionList
{
    public RepetitiveTransaction[] RepetitiveTransactions { set; get; }
    protected int position = 0;

    public void Add(RepetitiveTransaction repetitiveTransaction)
    {
        RepetitiveTransactions[position] = repetitiveTransaction;
        position++;
    }

    public int GetLength()
    {
        return position;
    }

    public string GetTransaction(int i)
    {
        return RepetitiveTransactions[i].ToString();
    }

}

// ----------------------------------

class HomeAccounting
{
    public static char MainMenu()
    {
        Console.WriteLine("1- Add transaction");
        Console.WriteLine("2- Add repetitive transaction");
        Console.WriteLine("3- Show transactions");
        Console.WriteLine("4- Search by text");
        Console.WriteLine("Q- Quit");
        return Console.ReadLine()[0];
    }

    static void Main(string[] args)
    {
        const int SIZE = 1000;
        TransactionList tList = new TransactionList();
        RepetitiveTransactionList rList = new RepetitiveTransactionList();

        bool finished = false;

        do
        {
            switch (MainMenu())
            {
                case '1':
                    Console.WriteLine("Day: ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Month: ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Description: ");
                    string description = Console.ReadLine();

                    tList.Add(
                        new Transaction(day, month, year, amount, description)
                        );
                    break;
                case '2':
                    Console.WriteLine("Day: ");
                    int rday = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Month: ");
                    int rmonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Amount: ");
                    int ramount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Description: ");
                    string rdescription = Console.ReadLine();

                    rList.Add(
                        new RepetitiveTransaction
                        (rday, rmonth, ramount, rdescription)
                        );
                    break;
                case '3':
                    Console.WriteLine("Month: ");
                    int sMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Year: ");
                    int sYear = Convert.ToInt32(Console.ReadLine());
                    int size = tList.GetLength();
                    for (int i = 0; i < size; i++)
                    {
                        if (tList.GetTransaction(i).Contains(""+sMonth)
                            && tList.GetTransaction(i).Contains(""+sYear))
                        Console.WriteLine(tList.GetTransaction(i));
                    }
                    size = rList.GetLength();
                    for (int i = 0; i < size; i++)
                    {
                        if (rList.GetTransaction(i).Contains("" + sMonth)
                            && rList.GetTransaction(i).Contains("" + sYear))
                            Console.WriteLine(rList.GetTransaction(i));
                    }
                    break;
                    break;
                case '4':
                    Console.WriteLine("Enter text to search: ");
                    string search = Console.ReadLine();

                    int sSize = tList.GetLength();
                    for (int i = 0; i < sSize; i++)
                    {
                        if(tList.GetTransaction(i).Contains(search));
                            Console.WriteLine(tList.GetTransaction(i));
                    }
                    size = rList.GetLength();
                    for (int i = 0; i < sSize; i++)
                    {
                        if(rList.GetTransaction(i).Contains(search))
                            Console.WriteLine(tList.GetTransaction(i));
                    }
                    break;
                case 'Q': finished = true;
                    break;
            }
        } while (!finished);
    }
}

