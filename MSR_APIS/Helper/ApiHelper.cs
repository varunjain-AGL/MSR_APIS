using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System.Text.Json;
using MSR_APIS.Models;
namespace MSR_APIS.Helper
{
    public class ApiHelper
    {
        private readonly IConfiguration _configuration;
        public ApiHelper(IConfiguration configuration) { _configuration = configuration; }

        public async Task<ApiResponse<object>> GetMSRBannerAsync(string cityName)
        {
                var apiUrl = _configuration["Get_Msr_Banner"];
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    
                    var requestBody = new StringContent(JsonSerializer.Serialize(new { CityName = cityName }), Encoding.UTF8, "application/json");

                   
                    var response = await client.PostAsync(apiUrl, requestBody);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonSerializer.Deserialize<object>(content); 

                        return new ApiResponse<object>
                        {
                            IsSuccess = true,
                            Data = result,
                            Message = "Request was successful."
                        };
                    }
                    else
                    {
                        return new ApiResponse<object>
                        {
                            IsSuccess = false,
                            Message = "Failed to get a successful response from the API",
                            StatusCode = (int)response.StatusCode
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse<object>
                    {
                        IsSuccess = false,
                        Message = "An error occurred while calling the API.",
                        Error = ex.Message,
                        StatusCode = 500
                    };
                }
            }
        }

        public async Task<ApiResponse<LoyaltyBadgeResult>> GetTierDetailsByIdAsync(TierRequest request)
        {
            var apiurl = _configuration["Get_Tier_By_Id"];
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var requestBody = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiurl, requestBody);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        LoyaltyBadgeResult result = JsonSerializer.Deserialize<LoyaltyBadgeResult>(content);
                        return new ApiResponse<LoyaltyBadgeResult>
                        {
                            IsSuccess = true,
                            Data = result,
                            Message = "Request was successful."
                        };
                    }
                    else
                    {
                        return new ApiResponse<LoyaltyBadgeResult>
                        {
                            IsSuccess = false,
                            Message = "Failed to get a successful response from the API",
                            StatusCode = (int)response.StatusCode
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse<LoyaltyBadgeResult>
                    {
                        IsSuccess = false,
                        Message = "An error occurred while calling the API.",
                        Error = ex.Message,
                        StatusCode = 500
                    };
                }
            }
        }

        public async Task<ApiResponse<object>> GetMSRPopUpAsync(string cityName)
        {
            var apiUrl = _configuration["Get_Msr_popup"];
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    
                    var requestBody = new StringContent(JsonSerializer.Serialize(new { CityName = cityName }), Encoding.UTF8, "application/json");

                   
                    var response = await client.PostAsync(apiUrl, requestBody);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonSerializer.Deserialize<object>(content); 

                        return new ApiResponse<object>
                        {
                            IsSuccess = true,
                            Data = result,
                            Message = "Request was successful."
                        };
                    }
                    else
                    {
                        return new ApiResponse<object>
                        {
                            IsSuccess = false,
                            Message = "Failed to get a successful response from the API",
                            StatusCode = (int)response.StatusCode
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse<object>
                    {
                        IsSuccess = false,
                        Message = "An error occurred while calling the API.",
                        Error = ex.Message,
                        StatusCode = 500
                    };
                }
            }
        }

        public async Task<ApiResponse<object>> SendMSREmailAsync(EmailTemplate request)
        {
            var apiUrl = _configuration["Send_Mail_MSR"];
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    
                    var requestBody = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");

                   
                    var response = await client.PostAsync(apiUrl, requestBody);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonSerializer.Deserialize<object>(content); 

                        return new ApiResponse<object>
                        {
                            IsSuccess = true,
                            Data = result,
                            Message = "Request was successful."
                        };
                    }
                    else
                    {
                        return new ApiResponse<object>
                        {
                            IsSuccess = false,
                            Message = "Failed to get a successful response from the API",
                            StatusCode = (int)response.StatusCode
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse<object>
                    {
                        IsSuccess = false,
                        Message = "An error occurred while calling the API.",
                        Error = ex.Message,
                        StatusCode = 500
                    };
                }
            }
        }
        public async Task<ApiResponse<string>> GetAPIForSupportAsync()
        {
            var apiUrl = _configuration["Get_Support"];
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        return new ApiResponse<string>
                        {
                            IsSuccess = true,
                            Data = content,
                            Message = "Request was successful."
                        };
                    }
                    else
                    {
                        return new ApiResponse<string>
                        {
                            IsSuccess = false,
                            Message = "Failed to get a successful response from the API",
                            StatusCode = (int)response.StatusCode
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new ApiResponse<string>
                    {
                        IsSuccess = false,
                        Message = "An error occurred while calling the API.",
                        Error = ex.Message,
                        StatusCode = 500
                    }; 
                }
            }
        }
    }
}
    