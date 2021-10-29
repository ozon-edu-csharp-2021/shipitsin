using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.HttpModels;

namespace OzonEdu.MerchandiseService.HttpClient
{
    public interface IMerchandiseHttpClient
    {
        Task<IssueMerchResponse> IssueMerch(IssueMerchRequest request, CancellationToken token);
        Task<GetIssuedMerchResponse> GetIssuedMerch(GetIssuedMerchRequest request, CancellationToken token);
    }

    

    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public MerchandiseHttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IssueMerchResponse> IssueMerch(IssueMerchRequest request, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync(
                $"v1/api/merch/employee/{request.Employee.Id}/merch_type/{(int)request.MerchType}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<IssueMerchResponse>(body);
        }

        public async Task<GetIssuedMerchResponse> GetIssuedMerch(GetIssuedMerchRequest request, CancellationToken token)
        {
            using var response =
                await _httpClient.GetAsync($"v1/api/merch/employee/id:{request.Employee.Id}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<GetIssuedMerchResponse>(body);
        }
    }
}