using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab_Test_5_Set_B.Gateway;
using Lab_Test_5_Set_B.Models;

namespace Lab_Test_5_Set_B.Manager
{
    public class VoteManager
    {
        VoteGateway aVoteGateway = new VoteGateway();

        public string SaveVoter(Voter aVoter)
        {
            if (aVoteGateway.IsVoterIdExist(aVoter))
            {
                return "Voter Already Exists";
            }
            else
            {
                int rowAffected = aVoteGateway.SaveVoter(aVoter);
                if (rowAffected > 0)
                {
                    return "Voter Info Saved Successfully";
                }
                return "Voter Info Wasn't Saved";
            }

        }

        public string SaveCandidate(Candidate aCandidate)
        {
            if (aVoteGateway.IsCandidateExist(aCandidate))
            {
                return "Candidate Already Exists";
            }
            else
            {
                int rowAffected = aVoteGateway.SaveCandidate(aCandidate);
                if (rowAffected > 0)
                {
                    return "Candidate Info Saved Successfully";
                }
                return "Candidate Info Wasn't Saved";
            }
        }

        public List<Candidate> GetAllCandidateSymbols()
        {
            return aVoteGateway.GetAllCandidateSymbols();
        }

        public string CastVote(CastVote aCastVote)
        {
            if (aVoteGateway.VoterIdExist(aCastVote))
            {
                if (aVoteGateway.isVoteCasted(aCastVote))
                {
                    return "This Voter Already Casted His/Her Vote, So S/He Can't Cast Any More Vote";
                }
                else
                {
                    int rowAffected = aVoteGateway.CastVote(aCastVote);
                    if (rowAffected > 0)
                    {
                        return "Vote Casted";
                    }
                }
            }
            else
            {
                return "This Voter Doesn't Exist Into The System";
            }
            return "Vote wasn't Casted";
        }

        public List<ViewVote> GetVoteResults()
        {
            return aVoteGateway.GetVoteResults();
        }
    }
}