namespace PaymentSystem.Common.APIModel
{
    public interface IRequestModel
    {
    }

    public class RequestModelBase : IRequestModel
    {
        public string RequestBodyRaw { get; set; }
    }
}