public class DefaultDiscount: DiscountStrategy
{
    public float GetDiscount(Product product)
    {
        float discount = 0;

        if(product.price < 2.0f)
            discount = 5;
        else if(product.price < 5.0f)
            discount = 10;  
        else
            discount = 12.5f;

        return product.price - product.price * (discount/100);
    }

}
