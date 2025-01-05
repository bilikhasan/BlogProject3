namespace BlogProject3.PresentationLayer.Helpers
{
    public static class DateTimeExtensions
    {
        public static string ToDaysAgo(this DateTime dateTime)
        {
            var daysAgo = (DateTime.Now - dateTime).Days;
            return $"{daysAgo} gün önce";
        }
    }
}
