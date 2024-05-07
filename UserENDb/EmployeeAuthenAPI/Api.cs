namespace EmployeeAuthenAPI
{
    public static class Api
    {
        public static void ApiConfiguration(this WebApplication app)
        {
            app.MapPost(pattern: "/Register", Register);
            app.MapPost(pattern: "/Login", Login);
        }


        public static async Task<IResult> Register(IAuthenService authenService, EmployeeRegistration employeeInput)
        {
            try
            {
                return Results.Ok(await authenService.Register(employeeInput));
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> Login(IAuthenService authenService, EmployeeInput employeeInput)
        {
            try
            {
                return Results.Ok(await authenService.Login(employeeInput));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
