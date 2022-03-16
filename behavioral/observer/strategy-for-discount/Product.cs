public class Product
{
    private string _name = "";
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    private float _price = 0;
    public float price
    {
        get { return _price; }
        set { _price = value; }
    }

    private bool _isConsumable = false;
    public bool isConsumable
    {
        get { return _isConsumable; }
        set { _isConsumable = value; }
    }

    public Product(string name, float price, bool isConsumable)
    {
        this.name = name;
        this.price = price;
        this.isConsumable = isConsumable;
    }

}