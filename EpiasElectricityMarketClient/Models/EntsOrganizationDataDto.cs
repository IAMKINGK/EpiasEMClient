﻿namespace EpiasElectricityMarketClient.Models
{
    public partial class EntsOrganizationDataDto
    {
        /// <summary>
        /// Organizasyon ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Organizasyon Kodu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// Organizasyon Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Organizasyon Kısa Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationShortName { get; set; }

    }
}