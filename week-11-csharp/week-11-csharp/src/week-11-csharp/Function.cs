using Amazon.Lambda.Core;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace week_11_csharp;
public class Function
{
  public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
  {
    
    var response = new APIGatewayHttpApiV2ProxyResponse
    {
      StatusCode = (int)HttpStatusCode.OK,
      // json body
      Body = System.Text.Json.JsonSerializer.Serialize(new { Message = "This is my C# API (I Hate C#)" }),
      Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
    };

    return response;
  }
}
