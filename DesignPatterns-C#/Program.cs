//using DesignPatterns_C_.DependencyInjectionPattern;
//using DesignPatterns_C_.FactoryPattern;
using DesignPatterns_C_.Models;
using DesignPatterns_C_.RepositoryPattern;
using DesignPatterns_C_.StrategyPattern;
using DesignPatterns_C_.UnitOfWorkPattern;
//using DesignPatterns_C_.Singleton;

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
//var beer = new Beer("Toña", "Toña", 1);
//var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
//drinkWithBeer.Build();


//Repository con Entity
//using (var context = new DesignPatternsContext())
//{
//    var beerRepository = new BeerRepository(context);
//    var newBeer = new Beer();

//    newBeer.Name = "Corona";
//    newBeer.Style = "Corona";

//    beerRepository.Add(newBeer);
//    beerRepository.Save();

//    foreach (var beer in beerRepository.Get())
//    {
//        Console.WriteLine(beer.Name);
//    }
//}

//Repository con Entity Generic
//using (var context = new DesignPatternsContext())
//{
//    var beerRepository = new Repository<Beer>(context);
//    var newBeer = new Beer();

//    newBeer.Name = "Corona";
//    newBeer.Style = "Corona";

//    beerRepository.Add(newBeer);
//    beerRepository.Save();

//    foreach (var beer in beerRepository.Get())
//    {
//        Console.WriteLine(beer.Name);
//    }

//    var brandRepository = new Repository<Brand>(context);
//    var newBrand = new Brand();

//    newBrand.Name = "Fuller";

//    brandRepository.Add(newBrand);
//    brandRepository.Save();

//    foreach (var brand in brandRepository.Get())
//    {
//        Console.WriteLine(brand.Name);
//    }
//}

//UnitOfWork
//using (var context = new DesignPatternsContext())
//{
//    var unitOfWork = new UnitOfWork(context);

//    var beers = unitOfWork.Beers;
//    var beer = new Beer()
//    {
//        Name = "Spark Hard Seltzer ",
//        Style = "Spark Hard Seltzer "
//    };

//    beers.Add(beer);

//    var brands = unitOfWork.Brands;

//    var brand = new Brand()
//    {
//        Name= "Flor de Caña"
//    };

//    brands.Add(brand);

//    unitOfWork.Save();
//}

//Strategy
var context = new Context(new CarStrategy());
context.Run();
context.Strategy = new MotoStrategy();
context.Run();
context.Strategy = new BicycleStrategy();
context.Run();
