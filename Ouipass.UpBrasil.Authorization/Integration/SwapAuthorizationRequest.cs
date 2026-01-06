using System.Text.Json.Serialization;

namespace UpBrasil.Authorization.Integration;

public class SwapAuthorizationRequest
{
    [JsonPropertyName("product_id")]
    public string ProductId { get; set; }

    [JsonPropertyName("realm")]
    public string Realm { get; set; }

    [JsonPropertyName("acquiring_country_code")]
    public string AcquiringCountryCode { get; set; }

    [JsonPropertyName("acquiring_id")]
    public string AcquiringId { get; set; }

    [JsonPropertyName("added_time")]
    public DateTime AddedTime { get; set; }

    [JsonPropertyName("billing_amount")]
    public decimal BillingAmount { get; set; }

    [JsonPropertyName("billing_currency")]
    public int BillingCurrency { get; set; }

    [JsonPropertyName("txn_amount")]
    public decimal TransactionAmount { get; set; }

    [JsonPropertyName("currency")]
    public int Currency { get; set; }

    [JsonPropertyName("msg_type")]
    public int MessageType { get; set; }

    [JsonPropertyName("txn_type")]
    public int TransactionType { get; set; }

    [JsonPropertyName("internal_transaction_id")]
    public string InternalTransactionId { get; set; }

    [JsonPropertyName("pan_entry_mode")]
    public string PanEntryMode { get; set; }

    [JsonPropertyName("pin_sent")]
    public bool PinSent { get; set; }

    [JsonPropertyName("cobranded")]
    public bool Cobranded { get; set; }

    [JsonPropertyName("installments")]
    public InstallmentsDto Installments { get; set; }

    [JsonPropertyName("account")]
    public AccountDto Account { get; set; }

    [JsonPropertyName("card")]
    public CardDto Card { get; set; }

    [JsonPropertyName("card_token")]
    public CardTokenDto CardToken { get; set; }

    [JsonPropertyName("pos")]
    public PosDto Pos { get; set; }

    [JsonPropertyName("merchant")]
    public MerchantDto Merchant { get; set; }
}

public class InstallmentsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("number_of_installments")]
    public int NumberOfInstallments { get; set; }
}

public class AccountDto
{
    [JsonPropertyName("treasury_account_holder_id")]
    public string TreasuryAccountHolderId { get; set; }

    [JsonPropertyName("account_holder_id")]
    public string AccountHolderId { get; set; }

    [JsonPropertyName("balance_account_group_id")]
    public string BalanceAccountGroupId { get; set; }

    [JsonPropertyName("balance_account_id")]
    public string BalanceAccountId { get; set; }

    [JsonPropertyName("available_balance")]
    public decimal AvailableBalance { get; set; }
}

public class CardDto
{
    [JsonPropertyName("card_id")]
    public string CardId { get; set; }

    [JsonPropertyName("pan_masked")]
    public string PanMasked { get; set; }

    [JsonPropertyName("card_issuance_date")]
    public DateTime CardIssuanceDate { get; set; }

    [JsonPropertyName("expiry_mm_yyyy")]
    public string ExpiryMonthYear { get; set; }

    [JsonPropertyName("brand")]
    public string Brand { get; set; }
}

public class CardTokenDto
{
    [JsonPropertyName("wallet_id")]
    public int WalletId { get; set; }

    [JsonPropertyName("wallet_name")]
    public string WalletName { get; set; }
}

public class PosDto
{
    [JsonPropertyName("chip_capability")]
    public bool ChipCapability { get; set; }

    [JsonPropertyName("contactless_capability")]
    public bool ContactlessCapability { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("magnetic_stripe_capability")]
    public bool MagneticStripeCapability { get; set; }

    [JsonPropertyName("pin_entry_capability")]
    public bool PinEntryCapability { get; set; }
}

public class MerchantDto
{
    [JsonPropertyName("mcc")]
    public string Mcc { get; set; }

    [JsonPropertyName("merchant_city")]
    public string MerchantCity { get; set; }

    [JsonPropertyName("merchant_country")]
    public string MerchantCountry { get; set; }

    [JsonPropertyName("merchant_id")]
    public string MerchantId { get; set; }

    [JsonPropertyName("merchant_name")]
    public string MerchantName { get; set; }

    [JsonPropertyName("merchant_document")]
    public long MerchantDocument { get; set; }
}
