namespace MicroserviceDemo.Web.Utility
{
    public class SD
    {
        public enum ApiType
        {
            GET,
            PUT,
            POST,
            DELETE
        }

        public static string CouponAPIBase { get; set; }
    }
}