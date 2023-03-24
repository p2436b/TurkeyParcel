using System.Text.Json;

using var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://cbsapi.tkgm.gov.tr/megsiswebapi.v3/api/maksIdariYapi/");

try
{
  var response = await httpClient.GetStringAsync("illiste");
  if (string.IsNullOrEmpty(response) is false)
  {
    var result = JsonSerializer.Deserialize<Response>(response);
    Console.WriteLine(response);
  }
}
catch (Exception ex)
{
  Console.WriteLine(ex.InnerException.Message);
}
