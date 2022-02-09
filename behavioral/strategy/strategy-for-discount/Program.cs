/*  Here's our Context...  */
Product product1 = new Product("100 coins", 1.99f, true);
Product product2 = new Product("Warrior Skin", 4.49f, false);
Product product3 = new Product("1000 coins", 14.99f, true);

/*  At any point this client code must know which strategy to use.
    However, the client does not know "how" the strategy is working.  */
DiscountStrategy defaultDiscount = new DefaultDiscount();
Console.WriteLine("Testing Default Discount Strategy...");
Console.WriteLine(String.Format("{0:0.00}: {1:0.00}; {2:0.00}: {3:0.00}; {4:0.00}: {5:0.00}.", product1.name, defaultDiscount.GetDiscount(product1)
                                                                                            , product2.name, defaultDiscount.GetDiscount(product2)
                                                                                            , product3.name, defaultDiscount.GetDiscount(product3) ));
Console.WriteLine("Done!\n");

DiscountStrategy birthdayDiscount = new BirthdayDiscount();
Console.WriteLine("Testing Birthday Discount Strategy...");
Console.WriteLine(String.Format("{0:0.00}: {1:0.00}; {2:0.00}: {3:0.00}; {4:0.00}: {5:0.00}.", product1.name, birthdayDiscount.GetDiscount(product1)
                                                                                            , product2.name, birthdayDiscount.GetDiscount(product2)
                                                                                            , product3.name, birthdayDiscount.GetDiscount(product3) ));
Console.WriteLine("Done!\n");

DiscountStrategy consumableDiscount = new ConsumableDiscount();
Console.WriteLine("Testing Consumable Discount Strategy...");
Console.WriteLine(String.Format("{0:0.00}: {1:0.00}; {2:0.00}: {3:0.00}; {4:0.00}: {5:0.00}.", product1.name, consumableDiscount.GetDiscount(product1)
                                                                                            , product2.name, consumableDiscount.GetDiscount(product2)
                                                                                            , product3.name, consumableDiscount.GetDiscount(product3) ));
Console.WriteLine("Done!\n");

DiscountStrategy weekendDiscount = new WeekendDiscount();
Console.WriteLine("Testing Weekend Discount Strategy...");
Console.WriteLine(String.Format("{0:0.00}: {1:0.00}; {2:0.00}: {3:0.00}; {4:0.00}: {5:0.00}.", product1.name, weekendDiscount.GetDiscount(product1)
                                                                                            , product2.name, weekendDiscount.GetDiscount(product2)
                                                                                            , product3.name, weekendDiscount.GetDiscount(product3) ));
Console.WriteLine("Done!\n");