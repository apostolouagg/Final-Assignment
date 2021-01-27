using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Ergasia3_Database
{
    public class DbManager
    {
        private string ConnectionString { get; set; }
        public List<Case> Cases { get; set; }

        public DbManager(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.Cases = new List<Case>();
            UpdateCases();
        }

        /// <summary>
        /// Add a new case to the database.
        /// </summary>
        public void AddCase(Case newCase)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var query = $@"INSERT INTO Cases(FullName, Email, PhoneNumber, Gender, BirthDay, Address, TimeOfCase) VALUES('{newCase.FullName}', '{newCase.Email}', '{newCase.PhoneNumber}', '{newCase.Gender.ToString()}', '{newCase.BirthDay}', '{newCase.Address}', '{newCase.TimeOfCase}');";
                var cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

                var casekey = conn.LastInsertRowId;

                if (newCase.UnderlyingDiseases != null)
                {
                    foreach (var newCaseUnderlyingDisease in newCase.UnderlyingDiseases)
                    {
                        var query2 = $@"INSERT INTO UnderlyingDiseases(Disease, CaseID) VALUES('{newCaseUnderlyingDisease.Disease}', '{casekey}');";
                        var cmd2 = new SQLiteCommand(query2, conn);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }

            UpdateCases();
        }

        /// <summary>
        /// Saves any changes that happened to the given case.
        /// </summary>
        public void UpdateCase(Case newCase)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var query = $@"UPDATE Cases SET FullName = '{newCase.FullName}', Email = '{newCase.Email}', PhoneNumber = '{newCase.PhoneNumber}', Gender = '{newCase.Gender.ToString()}', BirthDay = '{newCase.BirthDay}', Address = '{newCase.Address}', TimeOfCase = '{newCase.TimeOfCase}' WHERE ID = {newCase.ID};";
                var cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            UpdateCases();
        }
        /// <summary>
        /// Saves any changes that happened to the given case's underlying diseases.
        /// </summary>
        public void UpdateUnderlyingDiseases(Case newCase)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                /*
                 * First check if there is a difference between the new list and the old list
                 * If there is then we delete all the case's diseases and then we insert the new ones.
                 */
                // Remove old diseases
                var query = $@"DELETE FROM UnderlyingDiseases WHERE CaseID = {newCase.ID};";
                var cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

                foreach (var newCaseUnderlyingDisease in newCase.UnderlyingDiseases) // Insert new diseases
                {
                    query = $@"INSERT INTO UnderlyingDiseases(Disease, CaseID) VALUES('{newCaseUnderlyingDisease.Disease}', '{newCase.ID}');";
                    cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            UpdateCases();
        }

        /// <summary>
        /// Deletes the case provided.
        /// </summary>
        public void DeleteCase(Case deleteCase)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                // First Delete diseases
                var query = $"DELETE FROM UnderlyingDiseases WHERE CaseID = {deleteCase.ID};";
                var cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

                // Then delete Case
                query = $"DELETE FROM Cases WHERE ID = {deleteCase.ID};";
                cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            UpdateCases();
        }

        /// <summary>
        /// Updates the Cases List
        /// </summary>
        private void UpdateCases() => GetAllCases();

        /// <summary>
        /// Returns a list with all cases
        /// </summary>
        public List<Case> GetAllCases()
        {
            List<Case> cases = new List<Case>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var query = "SELECT * FROM Cases;";
                var cmd = new SQLiteCommand(query, conn);
                var readerCases = cmd.ExecuteReader();

                while (readerCases.Read())
                {
                    var query2 = $"SELECT * FROM UnderlyingDiseases WHERE CaseID == {readerCases.GetInt16(0)};";
                    var cmd2 = new SQLiteCommand(query2, conn);
                    var readerUD = cmd2.ExecuteReader();

                    var diseases = new List<UnderlyingDisease>();
                    while (readerUD.Read())
                    {
                        diseases.Add(new UnderlyingDisease(readerUD.GetInt16(0), readerUD.GetString(1),readerUD.GetInt16(2)));
                    }
                    cases.Add(new Case(readerCases.GetInt16(0), readerCases.GetString(1),
                        readerCases.GetString(2), readerCases.GetString(3) ,readerCases.GetString(4), readerCases.GetString(5),
                        readerCases.GetString(6), readerCases.GetString(7), diseases));
                }

                Cases = cases;
                return cases;
            }
        }
    }
}
