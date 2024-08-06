namespace DotNetTribe_UI_Shared.Models.UtilModels
{
    public class ApiResponseModel<TEntity>
    {
        public TEntity? data { get; set; }
        public ResponseStatus status { get; set; }
        public string? message { get; set; }
    }

    public enum ResponseStatus
    {
        OK = 1,
        APP_ERROR = 2,
        FATAL_ERROR = 3,
    }
}
