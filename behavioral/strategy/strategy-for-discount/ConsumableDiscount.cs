public class ConsumableDiscount: DiscountStrategy
{
    public float GetDiscount(Product product)
    {
        float discount = 0;

        if(product.isConsumable)
        {
            discount = 20;
            return product.price - product.price * (discount/100);
        }
        else
        {
            DiscountStrategy dd = new DefaultDiscount();
            return dd.GetDiscount(product);
        }
    }
    
}
