using Elasticsearch.Net;
using System;

namespace Elasticsearch_NET
{
    public class ESLowLevelClient
    {

        public void con(){
            var settings = new ConnectionConfiguration(new Uri("http://localhost:9200"))
                    .RequestTimeout(TimeSpan.FromMinutes(2));
            var connection = new ElasticLowLevelClient(settings);

            var searchResponse = connection.Search<StringResponse>("test", PostData.Serializable(new
            {
                from = 0,
                size = 10,
                query = new
                {
                    match = new
                    {
                        nombre = new
                        {
                            query = "Yesid2"
                        }
                    }
                }
            }));

            var successful = searchResponse.Success;
            var responseJson = searchResponse.Body;
            Console.WriteLine(responseJson);
        }       

    }
}
