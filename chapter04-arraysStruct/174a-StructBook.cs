using System;

class StructBook
{
    struct book
    {
        public string title;
        public string author;
        public int year;
        public bool isElectronic;
    }


    static void Main()
    {
        book b;
        b.title = "The Adventures of Sherlock Holmes";
        b.author = "Sir Arthur Conan Doyle";
        b.year = 2001;
        b.isElectronic = false;

    }
}
