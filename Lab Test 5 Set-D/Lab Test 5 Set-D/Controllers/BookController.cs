using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_Test_5_Set_D.Manager;
using Lab_Test_5_Set_D.Models;

namespace Lab_Test_5_Set_D.Controllers
{
    public class BookController : Controller
    {
        BookManager aBookManager = new BookManager();
        public ActionResult StartPage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveBook()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult SaveBook(Book aBook)
        {
            ViewBag.Message = aBookManager.SaveBook(aBook);
            return View();
        }
        
        [HttpGet]
        public ActionResult SaveMember()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult SaveMember(Member aMember)
        {
            ViewBag.Message = aBookManager.SaveMember(aMember);
            return View();
        }
        
        [HttpGet]
        public ActionResult BorrowBook()
        {
            ViewBag.BooksInfo = aBookManager.GetAllBooks();
            return View();
        } 
        [HttpPost]
        public ActionResult BorrowBook(BorrowBook aBorrowBook)
        {
            ViewBag.Message = aBookManager.SaveBorrowedBook(aBorrowBook);
            ViewBag.BooksInfo = aBookManager.GetAllBooks();
            return View();
        }

        //public IEnumerable<SelectListItem> GetAllBookTitle()
        //{
        //    List<SelectListItem> selectListItems = new List<SelectListItem>()
        //    {
        //        new SelectListItem(){Text = "---Select---",Value = ""},                
        //    };
        //    List<Book> books = aBookManager.GetAllBooks();
        //    foreach (Book aBook in books)
        //    {
        //        SelectListItem selectListItem = new SelectListItem();
        //        selectListItem.Text = aBook.Title;
        //        selectListItem.Value = aBook.Id.ToString();
        //        selectListItems.Add(selectListItem);
        //    }

        //    return selectListItems;
        //}
        public JsonResult GetBooksById(int bookId)
        {
            Book aBook = aBookManager.GetBooksById(bookId);
            return Json(aBook, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ReturnBook()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult ReturnBook(BorrowBook aBorrowBook)
        {
            ViewBag.Message = aBookManager.ReturnBook(aBorrowBook);
            return View();
        }

        public ActionResult GetBooksByMemberId(int MemberId)
        {
            BorrowBook aBorrowBook = aBookManager.GetBorrowedBooksByMemberId(MemberId);
            return Json(aBorrowBook, JsonRequestBehavior.AllowGet);
        }
    }
}