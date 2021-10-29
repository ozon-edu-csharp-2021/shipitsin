using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.HttpModels
{
    public class IssueMerchRequest
    {
        public IssueMerchRequest(Employee employee, MerchType merchType)
        {
            MerchType = merchType;
            Employee = employee;
        }

        public Employee Employee { get; }
        public MerchType MerchType { get; }
    }
}