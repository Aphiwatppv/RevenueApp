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
            app.MapPost(pattern: "/Register", Register);
            app.MapPost(pattern: "/Login", Login);


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

        public static async Task<IResult> Register([FromServices] IAuthServices Authservices, [FromBody] AuthAccess.Model.RegisteringUserInput registeringUserInput , string password)
        {
            try
            {
                return Results.Ok(await Authservices.RegisterUserAsync(registeringUserInput, password));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> Login([FromServices] IAuthServices Authservices , [FromBody] AuthAccess.Model.UserInput NewuserInput)
        {
            try
            {
                return Results.Ok(await Authservices.LoginMethodAsync(NewuserInput));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
