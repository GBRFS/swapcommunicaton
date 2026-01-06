using UpBrasil.Authorization.Integration;

namespace UpBrasil.Authorization.Application;

public class AuthorizationService
{
    public SwapAuthorizationResponse Authorize(SwapAuthorizationRequest request)
    {
        if (request.Account.AvailableBalance < request.BillingAmount)
        {
            return SwapAuthorizationResponse.Declined(
                request.InternalTransactionId,
                request.Account.AvailableBalance,
                "51"
            );
        }

        var newBalance = request.Account.AvailableBalance - request.BillingAmount;

        return SwapAuthorizationResponse.Approved(
            request.InternalTransactionId,
            newBalance
        );
    }
}
