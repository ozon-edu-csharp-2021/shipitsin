namespace OzonEdu.MerchandiseService.HttpModels
{
    public class IssueMerchResponse
    {
        public IssueMerchResponse(string status)
        {
            MerchIssueStatus = status;
        }
        
        public string MerchIssueStatus { get; }
    }
}