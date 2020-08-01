namespace NetCoreBookStore.Data.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Book Book { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
