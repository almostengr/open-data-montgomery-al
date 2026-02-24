using System.Text.Json.Serialization;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common.Resources;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations.Resources;

public sealed class CodeViolationResource : Resource
{
    public Attribute Attributes { get; set; }
    public Coordinates Geometry { get; set; }

    public class Attribute
    {
        [JsonPropertyName("OffenceNum")]
        public string OffenseNumber { get; set; }

        public string CaseDate { get; set; }
        public string CaseType { get; set; }
        public string CaseStatus { get; set; }
        public string Lienstatus { get; set; }

        [JsonPropertyName("ParcelNo")]
        public string ParcelNumber { get; set; }

        public string ParcelNumberTrimmed { get; set; }
        public string CouncilDistrict { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [JsonPropertyName("ComplaintRem")]
        public string ComplaintRemarks { get; set; }

        [JsonPropertyName("ParcelNo_X")]
        public decimal ParcelNumberX { get; set; }

        [JsonPropertyName("ParcelNo_Y")]
        public decimal ParcelNumberY { get; set; }

        public string Address1 { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public Guid GlobalId { get; set; }

        [JsonPropertyName("created_user")]
        public string CreatedUser { get; set; }

        [JsonPropertyName("created_date")]
        public long CreatedDate { get; set; }

        [JsonPropertyName("last_edited_user")]
        public string LastEditedUser { get; set; }

        [JsonPropertyName("last_edited_date")]
        public long LastEditedDate { get; set; }
    }

    public class Coordinates
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
    }
}