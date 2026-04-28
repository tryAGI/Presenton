
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnboardingQuestion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuestionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingQuestion" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="questionType"></param>
        /// <param name="order"></param>
        /// <param name="id"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnboardingQuestion(
            string question,
            string questionType,
            int order,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<string>? options)
        {
            this.Id = id;
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.QuestionType = questionType ?? throw new global::System.ArgumentNullException(nameof(questionType));
            this.Order = order;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingQuestion" /> class.
        /// </summary>
        public OnboardingQuestion()
        {
        }
    }
}