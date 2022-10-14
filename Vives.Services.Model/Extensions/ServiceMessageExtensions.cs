namespace Vives.Services.Model.Extensions
{
    public static class ServiceMessageExtensions
    {
        public static ServiceResult<T> JsonNull<T>(this ServiceResult<T> serviceResult)
        {
            serviceResult.AddJsonNull();
            return serviceResult;
        }

        public static ServiceResult JsonNull(this ServiceResult serviceResult)
        {
            serviceResult.AddJsonNull();
            return serviceResult;
        }

        private static void AddJsonNull(this ServiceResult serviceResult)
        {
            serviceResult.Messages.Add(new ServiceMessage
            {
                Code = "JsonNullError",
                Message = "Could not parse json.",
                Type = ServiceMessageType.Error
            });
        }
    }
}
