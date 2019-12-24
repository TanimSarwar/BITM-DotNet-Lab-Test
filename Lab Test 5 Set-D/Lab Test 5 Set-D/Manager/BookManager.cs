using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab_Test_5_Set_D.Gateway;
using Lab_Test_5_Set_D.Models;

namespace Lab_Test_5_Set_D.Manager
{
    public class BookManager
    {
        BookGateway aBookGateway = new BookGateway();
        public string SaveBook(Book aBook)
        {
            if (aBookGateway.IsBookTitleExist(aBook))
            {
                return "Sorry, Book Already Exists";
            }
            int rowAffetced = aBookGateway.SaveBook(aBook);
            if (rowAffetced > 0)
            {
                return "This book has been saved";
            }
            return "Book info wasn't saved";
        }

        public string SaveMember(Member aMember)
        {
            if (aBookGateway.IsMemberExist(aMember))
            {
                return "Sorry, Member Already Exists";
            }
            int rowAffetced = aBookGateway.SaveMember(aMember);
            if (rowAffetced > 0)
            {
                return "This member has been saved";
            }
            return "Member info wasn't saved";
        }

        public List<Book> GetAllBooks()
        {
            return aBookGateway.GetAllBooks();
        }

        public string SaveBorrowedBook(BorrowBook aBorrowBook)
        {
            if (aBookGateway.MemberNumberExist(aBorrowBook))
            {
                if (aBookGateway.IsMemberTookTheBook(aBorrowBook))
                {
                    return "The member has borrowed the book and didn't returned yet";
                }
                else
                {
                    int rowAffected = aBookGateway.SaveBorrowedBook(aBorrowBook);
                    if (rowAffected > 0)
                    {
                        return "This Book Has Been Borrowed By member whose number is: " + aBorrowBook.MemberId + ".";
                    }
                }

            }
            else
            {
                return "Sorry, Member number doesn't exists";
            }
            return "Borrowing book was Failed";
        }

        public Book GetBooksById(int bookId)
        {
            return aBookGateway.GetBooksbyId(bookId);
        }

        public string ReturnBook(BorrowBook aBorrowBook)
        {
            int rowAffected = aBookGateway.ReturnBook(aBorrowBook);
            if (rowAffected>0)
            {
                return "Book deleted";
            }
            return "Book not deleted";
        }

        public BorrowBook GetBorrowedBooksByMemberId(int memberId)
        {
            return aBookGateway.GetBorrowedBooksbyMemberId(memberId);
        }
    }
}