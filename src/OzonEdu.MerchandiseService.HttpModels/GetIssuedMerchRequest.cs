using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.HttpModels
{
    public class GetIssuedMerchRequest
    {
        public GetIssuedMerchRequest(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
    }
}