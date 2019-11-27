using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTest_4_Set_B.Manager;
using LabTest_4_Set_B.Models;

namespace LabTest_4_Set_B.Controllers
{
    public class SalesController : Controller
    {
        ItemManager aItemManager = new ItemManager();
        SalesManager aSalesManager = new SalesManager();
        //
        // GET: /Sales/
        [HttpGet]
        public ActionResult SaveItem()
        {
            ViewBag.ItemList = aItemManager.GetAllItems();
            return View();
        }
        [HttpPost]
        public ActionResult SaveItem(Sales sale)
        {
            ViewBag.ItemList = aItemManager.GetAllItems();
            ViewBag.Message = aSalesManager.Save(sale);
            return View();
        }

        public ActionResult GetItemSalesInfo(Sales sale)
        {
            ViewBag.ItemList = aItemManager.GetAllItems();
            ViewBag.SalesList = aSalesManager.SalesList(sale);
            return View();
        }

        public ActionResult StartPage()
        {
            return View();
        }
    }
}