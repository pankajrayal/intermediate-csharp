namespace D01_AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var ratings = this.CalculateRating(excludeOrders: true);
        }
    }
}
