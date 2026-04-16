using DesignPatterns_C_.DependencyInjectionPattern;
using DesignPatterns_C_.FactoryPattern;
using DesignPatterns_C_.Singleton;

//Singleton
//var singleton = Singleton.Instance;

//var log = Log.Instance;
//log.Save("Test 1");
//log.Save("Test 2");

//Factory
//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//SaleFactory internetSaleFactory = new InternetSaleFactory(10);

//ISale sale1 = storeSaleFactory.GetSale();
//sale1.Sell(15);

//ISale sale2 = internetSaleFactory.GetSale();
//sale2.Sell(15

//Dependency Injection
var beer = new Beer("Toña", "Toña", 1);
var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
drinkWithBeer.Build();


