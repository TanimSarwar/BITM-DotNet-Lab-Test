using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Lab_Test_5_Set_B.Models;

namespace Lab_Test_5_Set_B.Gateway
{
    public class VoteGateway
    {
        public string ConnectionString = WebConfigurationManager.ConnectionStrings["VoteDBConnection"].ConnectionString;
        public bool IsVoterIdExist(Voter aVoter)
        {
            string Query = "SELECT * FROM Voter WHERE VoterId = @voterId";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("voterId", aVoter.VotersId);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int SaveVoter(Voter aVoter)
        {
            string Query = "INSERT INTO Voter VALUES(@voterName,@voterId)";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("voterId", aVoter.VotersId);
            Command.Parameters.AddWithValue("voterName", aVoter.VotersName);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public bool IsCandidateExist(Candidate aCandidate)
        {
            string Query = "SELECT * FROM Candidate WHERE Symbol = @symbol";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("symbol", aCandidate.CandidateSymbol);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int SaveCandidate(Candidate aCandidate)
        {
            string Query = "INSERT INTO Candidate VALUES(@name,@symbol)";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("name", aCandidate.Candidatename);
            Command.Parameters.AddWithValue("symbol", aCandidate.CandidateSymbol);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Candidate> GetAllCandidateSymbols()
        {
            string Query = "SELECT * FROM Candidate";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Connection.Open();
            List<Candidate> candidates = new List<Candidate>();
            SqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Candidate aCandidate = new Candidate();
                aCandidate.Id = Convert.ToInt32(Reader["Id"].ToString());
                aCandidate.CandidateSymbol = Reader["Symbol"].ToString();
                candidates.Add(aCandidate);
            }
            Reader.Close();
            Connection.Close();
            return candidates;
        }

        public bool VoterIdExist(CastVote aCastVote)
        {
            string Query = "SELECT * FROM Voter WHERE VoterId = @voterId";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("voterId", aCastVote.VoterId);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int CastVote(CastVote aCastVote)
        {
            string Query = "INSERT INTO CastVote VALUES(@voterId, @candidateSymbol, '1')";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("voterId", aCastVote.VoterId);
            Command.Parameters.AddWithValue("candidateSymbol", aCastVote.CandidateSymbol);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool isVoteCasted(CastVote aCastVote)
        {
            string Query = "SELECT * FROM CastVote WHERE VoterId = @voterId";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("voterId", aCastVote.VoterId);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            bool hasRows = Reader.HasRows;
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public List<ViewVote> GetVoteResults()
        {
            string Query = "SELECT [Vote].[dbo].Candidate.Name, [Vote].[dbo].Candidate.Symbol, SUM([Vote].[dbo].CastVote.No) AS Total FROM [Vote].[dbo].[CastVote] INNER JOIN [Vote].[dbo].[Candidate] On CastVote.CandidateSymbol = Candidate.Id Group By [Vote].[dbo].Candidate.Symbol,[Vote].[dbo].Candidate.Name ORDER BY SUM([Vote].[dbo].CastVote.No) DESC";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Connection.Open();
            List<ViewVote> viewVotes = new List<ViewVote>();
            SqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewVote aViewVote = new ViewVote();
                aViewVote.CandidateSymbol =Reader["Symbol"].ToString();
                aViewVote.CandidateName = Reader["Name"].ToString();
                aViewVote.VoteNo = Convert.ToInt32(Reader["Total"].ToString());
                viewVotes.Add(aViewVote);
            }
            Reader.Close();
            Connection.Close();
            return viewVotes;
        }
    }
}




//SELECT [Vote].[dbo].Candidate.Name, [Vote].[dbo].Candidate.Symbol, SUM([Vote].[dbo].CastVote.No) FROM [Vote].[dbo].[CastVote] INNER JOIN [Vote].[dbo].[Candidate] On CastVote.CandidateSymbol = Candidate.Id Group By [Vote].[dbo].Candidate.Symbol,[Vote].[dbo].Candidate.Name