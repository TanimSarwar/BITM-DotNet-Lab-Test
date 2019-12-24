using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using Lab_Test_5_Set_D.Models;

namespace Lab_Test_5_Set_D.Gateway
{
    public class BookGateway:Gateway
    {
        public int SaveBook(Book aBook)
        {
            Query = "INSERT INTO BookTable VALUES(@title, @author, @publisher)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("title", aBook.Title);
            Command.Parameters.AddWithValue("author", aBook.Author);
            Command.Parameters.AddWithValue("publisher", aBook.Publisher);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsBookTitleExist(Book aBook)
        {
            Query = "SELECT * FROM BookTable WHERE Title = @title";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("title", aBook.Title);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public bool IsMemberExist(Member aMember)
        {
            Query = "SELECT * FROM MemberTable WHERE Number = @number";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("number", aMember.Number);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int SaveMember(Member aMember)
        {
            Query = "INSERT INTO MemberTable VALUES(@number, @name)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("number", aMember.Number);
            Command.Parameters.AddWithValue("name", aMember.Name);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Book> GetAllBooks()
        {
            Query = "SELECT * FROM BookTable";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            List<Book> books = new List<Book>();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Book aBook = new Book();
                aBook.Id = Convert.ToInt32(Reader["Id"].ToString());
                aBook.Title = Reader["Title"].ToString();
                aBook.Author = Reader["Author"].ToString();
                aBook.Publisher = Reader["Publisher"].ToString();
                books.Add(aBook);
            }
            Reader.Close();
            Connection.Close();
            return books;
        }

        public bool MemberNumberExist(BorrowBook aBorrowBook)
        {
            Query = "SELECT * FROM MemberTable WHERE Number = @number";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("number", aBorrowBook.MemberId);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int SaveBorrowedBook(BorrowBook aBorrowBook)
        {
            Query = "INSERT INTO BorrowedBookTable VALUES(@memberNo, @bookId, @author, @publisher)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("memberNo", aBorrowBook.MemberId);
            Command.Parameters.AddWithValue("bookId", aBorrowBook.BookTitle);
            Command.Parameters.AddWithValue("author", aBorrowBook.Author);
            Command.Parameters.AddWithValue("publisher", aBorrowBook.Publisher);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Book GetBooksbyId(int bookId)
        {
            Query = "SELECT * FROM BookTable WHERE Id = @id";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("id", bookId);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Book aBooks = new Book();
            while (Reader.Read())
            {
                Book aBook = new Book()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    Title = Reader["Title"].ToString(),
                    Author = Reader["Author"].ToString(),
                    Publisher = Reader["Publisher"].ToString()
                };
                aBooks = aBook;
            }
            Reader.Close();
            Connection.Close();
            return aBooks;
        }

        public bool IsMemberTookTheBook(BorrowBook aBorrowBook)
        {
            Query = "SELECT * FROM BorrowedBookTable WHERE MemberId = @memberId AND BookTitle = @bookTitle";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("memberId", aBorrowBook.MemberId);
            Command.Parameters.AddWithValue("bookTitle", aBorrowBook.BookTitle);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public BorrowBook GetBorrowedBooksbyMemberId(int memberId)
        {
            Query = "SELECT * FROM BorrowedBookTable INNER JOIN BookTable ON BorrowedBookTable.BookTitle = BookTable.Id WHERE MemberId = @memberId";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("memberId", memberId);
            Connection.Open();
            Reader = Command.ExecuteReader();
            BorrowBook aBorrowBook = new BorrowBook();
            while (Reader.Read())
            {
                BorrowBook aBook = new BorrowBook()
                {
                    Id = Convert.ToInt32(Reader[""]),
                    BookName = Reader["Title"].ToString(),
                    Author = Reader["Author"].ToString(),
                    Publisher = Reader["Publisher"].ToString()
                };
                aBorrowBook = aBook;
            }
            Reader.Close();
            Connection.Close();
            return aBorrowBook;
        }

        public int ReturnBook(BorrowBook aBorrowBook)
        {
            Query = "DELETE FROM BorrowedBookTable WHERE MemberId = @memberId AND BookTitle = @bookTitle";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("memberId", aBorrowBook.MemberId);
            Command.Parameters.AddWithValue("bookTitle", aBorrowBook.Id);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}