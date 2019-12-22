using MeuAppVS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuAppVS
{
    public class MeuMiddleware
    {

        private readonly RequestDelegate _next;

        public MeuMiddleware( RequestDelegate next)
        {
            _next = next;

        }

    public async Task InvokeAsync(HttpContext contexto)
    {
        Console.WriteLine("\n\r --------Antes--------\n\r");

        await _next(contexto);

        Console.WriteLine("\n\r --------Depois--------\n\r");
    }
}
}

public static class MeuMiddlewareExtension
{
    public static IApplicationBuilder UseMeuMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MeuMiddleware>();
    }
}
