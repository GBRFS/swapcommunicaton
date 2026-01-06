using System.Text.Json.Serialization;

namespace UpBrasil.Authorization.Integration;

public class SwapAuthorizationResponse
{
    [JsonPropertyName("internal_transaction_id")]
    public string InternalTransactionId { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("response_code")]
    public string ResponseCode { get; set; }

    [JsonPropertyName("available_balance")]
    public decimal AvailableBalance { get; set; }

    public static SwapAuthorizationResponse Approved(
        string transactionId,
        decimal availableBalance)
    {
        return new SwapAuthorizationResponse
        {
            InternalTransactionId = transactionId,
            Status = "approved",
            ResponseCode = "00",
            AvailableBalance = availableBalance
        };
    }

    public static SwapAuthorizationResponse Declined(
        string transactionId,
        decimal availableBalance,
        string responseCode)
    {
        return new SwapAuthorizationResponse
        {
            InternalTransactionId = transactionId,
            Status = "declined",
            ResponseCode = responseCode,
            AvailableBalance = availableBalance
        };
    }
}
