namespace AppSegundoParcial.Models
{
    
   
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Temperatures
    {
        [JsonProperty("albumId")]
        public long AlbumId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public long Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }
    }
}


