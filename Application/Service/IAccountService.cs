
using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;
using Microsoft.Identity.Client;

namespace Application.Interface.Identity
{
    public interface IAccountService 
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);

        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();
        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        //Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        //Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
    }
}
