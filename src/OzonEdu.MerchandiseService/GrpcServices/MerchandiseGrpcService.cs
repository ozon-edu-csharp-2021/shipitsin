using System;
using System.Threading.Tasks;
using Grpc.Core;
using OzonEdu.MerchandiseService.Grpc;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.GrpcServices
{
    public class MerchandiseGrpcService : Grpc.MerchandiseServiceGrpc.MerchandiseServiceGrpcBase
    {
        private readonly IMerchandiseService _merchService;

        public MerchandiseGrpcService(IMerchandiseService merchService)
        {
            _merchService = merchService;
        }

        public override Task<IssueMerchResponse> IssueMerch(IssueMerchRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<GetIssuedMerchResponse> GetIssuedMerch(GetIssuedMerchRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}