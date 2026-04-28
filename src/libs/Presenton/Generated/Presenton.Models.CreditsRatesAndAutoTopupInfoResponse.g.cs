
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsRatesAndAutoTopupInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.CreditsRate Rates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_topup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Presenton.TopupInfo AutoTopup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPaymentMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsRatesAndAutoTopupInfoResponse" /> class.
        /// </summary>
        /// <param name="rates"></param>
        /// <param name="autoTopup"></param>
        /// <param name="hasPaymentMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsRatesAndAutoTopupInfoResponse(
            global::Presenton.CreditsRate rates,
            global::Presenton.TopupInfo autoTopup,
            bool hasPaymentMethod)
        {
            this.Rates = rates ?? throw new global::System.ArgumentNullException(nameof(rates));
            this.AutoTopup = autoTopup ?? throw new global::System.ArgumentNullException(nameof(autoTopup));
            this.HasPaymentMethod = hasPaymentMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsRatesAndAutoTopupInfoResponse" /> class.
        /// </summary>
        public CreditsRatesAndAutoTopupInfoResponse()
        {
        }
    }
}