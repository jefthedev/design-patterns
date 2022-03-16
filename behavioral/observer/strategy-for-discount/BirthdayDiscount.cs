public class BirthdayDiscount: DiscountStrategy
{
    public float GetDiscount(Product product)
    {
        float discount = 0;

        if(product.price < 5.0f)
            discount = 10;
        else
            discount = 20;  

        return product.price - product.price * (discount/100);
    }
    
}
