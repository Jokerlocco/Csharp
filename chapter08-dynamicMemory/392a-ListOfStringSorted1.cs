// Diego Lezcano
using System;
using System.Collections.Generic;

class MySortedList
{
	protected List<string> list;
	public int Count
	{
		get
		{
			return list.Count;
		}
	}
	
	public MySortedList()
	{
		list = new List<string>();	
	}
	
	public void Add(string s)
	{
		bool foundPos = false;
		if(list.Count == 0)
		{
			list.Add(s);
		}
		else
		{
			for(int i = 0;i < list.Count && !foundPos;i++)
			{
				if(s.CompareTo(list[i]) < 0)
				{
					list.Insert(i, s);
					foundPos = true;
				}
			}	
			if(! foundPos)
			{
				list.Add(s);
			}			
		}
		
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
public class Ej
{
	public static void Main()
	{
		MySortedList msl = new MySortedList();
		
		msl.Add("Hola");
		msl.Add("Adios");
		msl.Add("Como estás");
		
		for(int i = 0;i < msl.Count;i++)
		{
			Console.WriteLine(msl.Get(i));
		}
	}
}
