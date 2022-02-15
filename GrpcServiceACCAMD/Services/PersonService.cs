using Grpc.Core;
using GrpcServiceACCAMD.Data;

namespace GrpcServiceACCAMD.Services
{
    public class PersonService : GrpcPersonService.GrpcPersonServiceBase
    {
        public override async Task<PersonResponse> GetPerson(StatusPersonRequest request, ServerCallContext context)
        {
            return await PersonRepository.GetById(request.Id);
        }

        public override Task<ResultRequest> Create(PersonRequest request, ServerCallContext context)
        {
            return base.Create(request, context);
        } 
        
        //http://localhost:5134


    }
}
