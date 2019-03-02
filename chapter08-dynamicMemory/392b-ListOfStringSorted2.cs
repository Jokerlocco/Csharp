using System;
using System.Collections.Generic;

public class MySortedList
{
    public int Count
    {
        get
        {
            return list.Count;
        }
    }
    private List<string> list;

    public MySortedList()
    {
        list = new List<string>();
    }

    public void Add(string cadena)
    {
        int index = 0;
        bool found = false;

        while (index < Count && !found)
        {
            if (String.Compare(cadena, list[index]) < 0)
            {
                found = true;
            }
            else
            {
                index++;
            }
        }

        list.Insert(index, cadena);
    }

    public string Get(int n)
    {
        return list[n];
    }

    public void RemoveAt(int n)
    {
        list.RemoveAt(n);
    }
}
