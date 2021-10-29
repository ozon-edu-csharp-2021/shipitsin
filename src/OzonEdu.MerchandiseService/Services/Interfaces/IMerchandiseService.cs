using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.Services.Interfaces
{
    public interface IMerchandiseService
    {
        Task<string> IssueMerch(Employee employee, MerchType merchType, CancellationToken token);
        Task<List<MerchType>> GetIssuedMerch(Employee employee, CancellationToken token);
    }
}