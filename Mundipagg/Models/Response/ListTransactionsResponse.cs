using Mundipagg.Models.Commons;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListTransactionsResponse
    {
        public List<GetTransactionResponse> Data { get; set; }

        public Paging Paging { get; set; }
    }
}