namespace TraversalProject.Areas.Admin.Models;

public class BookingExchangeVM
{
    public Exchange_rates[] exchange_rates { get; set; }
    public string base_currency_date { get; set; }
    public string base_currency { get; set; }
    public class Exchange_rates
    {
        public string currency { get; set; }
        public string exchange_rate_buy { get; set; }
    }
}