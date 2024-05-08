using Microsoft.VisualBasic;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyCollection<string> Authors { get; set; }
        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if(result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}