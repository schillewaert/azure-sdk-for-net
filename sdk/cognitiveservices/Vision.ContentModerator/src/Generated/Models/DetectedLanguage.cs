// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Detect language result.
    /// </summary>
    public partial class DetectedLanguage
    {
        /// <summary>
        /// Initializes a new instance of the DetectedLanguage class.
        /// </summary>
        public DetectedLanguage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetectedLanguage class.
        /// </summary>
        /// <param name="detectedLanguageProperty">The detected
        /// language.</param>
        /// <param name="status">The detect language status</param>
        /// <param name="trackingId">The tracking id.</param>
        public DetectedLanguage(string detectedLanguageProperty = default(string), Status status = default(Status), string trackingId = default(string))
        {
            DetectedLanguageProperty = detectedLanguageProperty;
            Status = status;
            TrackingId = trackingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the detected language.
        /// </summary>
        [JsonProperty(PropertyName = "DetectedLanguage")]
        public string DetectedLanguageProperty { get; set; }

        /// <summary>
        /// Gets or sets the detect language status
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "TrackingId")]
        public string TrackingId { get; set; }

    }
}
