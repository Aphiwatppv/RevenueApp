using AuthAccess.AuthService;
using AuthAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RevenueAPI
{
    public static class APIConfiguration
    {
        public static void ApiConfig(this WebApplication app)
        {
            app.MapGet(pattern: "/GetAllRecordAsync", GetAllRecordAsync);
            app.MapGet(pattern: "/GetDailyExpenseSummariesAsync/{limit}", GetDailyExpenseSummariesAsync);
            app.MapPost(pattern: "/Register", RegisterAsync);
            app.MapPost(pattern: "/Login", LoginAsync);


        }


        public static async Task<IResult> GetAllRecordAsync(IServices services)
        {
            try
            {
                return Results.Ok(await services.ExpenseIncomeRecordAsync());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        public static async Task<IResult> GetDailyExpenseSummariesAsync(IServices services , decimal limit)
        {
            try
            {
                return Results.Ok(await services.DailyExpenseSummariesAsync(limit));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> RegisterAsync(IAuthServices authService, RegisteringModel registeringModel)
        {
            try
            {
                return Results.Ok(await authService.RegisterMethod(registeringModel));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> LoginAsync(IAuthServices authService, UserInput userInput)
        {
            try
            {
                return Results.Ok(await authService.LoginMethodAsync(userInput));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
