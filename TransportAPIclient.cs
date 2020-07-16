using System;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;

    namespace Bus_API 
    
    {
        public class TransportApiClient 
        
        {
            private RestClient client;
                //creating a class that will fetch client api
            public TransportApiClient()
            //https://transportapi.com/v3/uk/bus/stop/490008660N/live.json?app_id=83f01434&app_key=9cf288a38ada72dc783da55d8821a9b7&group=no&nextbuses=yes
            { //creating new rest client
                client = new RestClient("https://transportapi.com/"); 
            }
                //breaking down api paths and inputing them as query parameters
            public BusDepartureResponse GetBusDeparturesForStop(string stopcode)
            {
                var request = new RestRequest("v3/uk/bus/stop/{stopcode}/live.json")
                .AddUrlSegment("stopcode", stopcode)
                .AddQueryParameter("app_id", "83f01434")
                .AddQueryParameter("app_key","9cf288a38ada72dc783da55d8821a9b7")
                .AddQueryParameter("group","no")
                .AddQueryParameter("nextbuses","yes");

                // getting a response and saving it into variable
                var response = client.Get<BusDepartureResponse>(request);
                return response.Data;
            }

        }
    }
          
