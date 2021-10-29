using System.Collections.Generic;

namespace OzonEdu.MerchandiseService.HttpModels
{
    public class GetIssuedMerchResponse
    {
        public GetIssuedMerchResponse(List<MerchType> merchTypes)
        {
            MerchTypes = merchTypes;
        }

        public List<MerchType> MerchTypes { get; }
    }
}