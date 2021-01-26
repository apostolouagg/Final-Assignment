namespace Ergasia3_Database
{
    public class UnderlyingDisease
    {
        public int ID { get; set; }
        public string Disease { get; set; }
        public int CaseID { get; set; }

        public UnderlyingDisease()
        {

        }

        public UnderlyingDisease(int id, string disease, int caseId)
        {
            this.ID = id;
            this.Disease = disease;
            this.CaseID = caseId;
        }

    }
}
