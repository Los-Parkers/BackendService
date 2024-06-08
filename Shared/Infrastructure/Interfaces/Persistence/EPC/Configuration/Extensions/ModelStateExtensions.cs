using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace catch_up_api.Shared.Infrastructure.Interfaces.Persistence.EPC.Configuration.Extensions
{
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorMessage(this ModelStateDictionary dictionary)
        {
            return dictionary
                .SelectMany(m => m.Value!.Errors)
                .Select(m => m.ErrorMessage)
                .ToList();
        }
    }
}
