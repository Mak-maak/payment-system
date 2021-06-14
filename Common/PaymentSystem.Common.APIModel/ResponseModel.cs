namespace PaymentSystem.Common.APIModel
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public string Code { get; set; } = "0000";
        public string Message { get; set; } = "Your request successfully completed";
    }
}