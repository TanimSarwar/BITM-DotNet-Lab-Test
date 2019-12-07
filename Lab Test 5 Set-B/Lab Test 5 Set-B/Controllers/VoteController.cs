using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_Test_5_Set_B.Manager;
using Lab_Test_5_Set_B.Models;

namespace Lab_Test_5_Set_B.Controllers
{
    public class VoteController : Controller
    {
        private VoteManager aVoteManager = new VoteManager();
        //
        // GET: /Vote/
        [HttpGet]
        public ActionResult StartPage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveVoter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveVoter(Voter aVoter)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = aVoteManager.SaveVoter(aVoter);
                return View();
            }
            return View();

        }

        [HttpGet]
        public ActionResult SaveCandidate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCandidate(Candidate aCandidate)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = aVoteManager.SaveCandidate(aCandidate);
                return View();
            }
            return View();
        }

        [HttpGet]
        public ActionResult CastVote()
        {
            ViewBag.CandidateSymbol = GetCandidatesSymbol();
            return View();
        }

        [HttpPost]
        public ActionResult CastVote(CastVote aCastVote)
        {
            ViewBag.Message = aVoteManager.CastVote(aCastVote);
            ViewBag.CandidateSymbol = GetCandidatesSymbol();
            return View();
        }
        [HttpGet]
        public ActionResult VoteResult()
        {
            ViewBag.VoteResult = aVoteManager.GetVoteResults();
            return View();
        }
        public IEnumerable<SelectListItem> GetCandidatesSymbol()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "---Select---",Value = ""},                
            };
            List<Candidate> candidates = aVoteManager.GetAllCandidateSymbols();
            foreach (Candidate candidate in candidates)
            {
                SelectListItem selectListItem = new SelectListItem();
                selectListItem.Text = candidate.CandidateSymbol;
                selectListItem.Value = candidate.Id.ToString();
                selectListItems.Add(selectListItem);
            }

            return selectListItems;
        }
    }
}