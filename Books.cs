namespace Book_Library.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        //public DateTime ? BorrowDate { get; set; }
        //public DateTime ? ReturnDate { get; set; }
        public bool ? IsBorrowed { get; set; }
        public DateTime ReturnedDate { get; internal set; }
        public DateTime BorrowedDate { get; internal set; }

        public Books()
        {
                
        }
    }
}
