﻿using System.Net.Http.Json;

namespace Cashly.Client.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly HttpClient _http;

    public AuthService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ServiceResponse<int>> Register(UserRegister request)
    {
        var result = await _http.PostAsJsonAsync("api/Auth/register", request);

        return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
    }
}
