namespace MarbellaMS.Requests
{
    public class ApproveGateInOutRequest
    {
        public int Id { get; set; }
        public string Condition { get; set; }
        public string ApprovedBy { get; set; }
    }
}
