using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.Services
{
    public class MerchandiseService : IMerchandiseService
    {
        public Task<string> IssueMerch(Employee employee, MerchType merchType, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MerchType>> GetIssuedMerch(Employee employee, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }
    }
}