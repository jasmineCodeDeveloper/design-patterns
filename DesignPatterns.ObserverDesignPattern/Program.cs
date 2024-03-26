// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//observer design pattern-behavioral category

//bir siteye email ile kayıt olduk diyelim bize haftalık bülten gönderiyorlar unscribe edersek bülten gelmez



var samsung = new Product("Samsung S23", 1000);
var apple = new Product("Apple Iphone 14",1000);

var amazon = new Amazon();
var yaseminObserver = new YaseminObserver("Yasemin Elvan");
var elvanObserver = new ElvanObserver("Elvan Yasemin");
amazon.Register(yaseminObserver, samsung);
amazon.Register(elvanObserver, apple);

//amazon.NotifyForProductName("Apple Iphone 14");
amazon.NotifyAll();//bütün observer'lara notification gider
//her kim hangi ürün için kendisini register etmişse onunla ilgli bilgi kendisine gider
Console.ReadLine();
class Amazon
{
	//subject içinde herhangi bir event gerçekleştiğinde observer'larına haber verir
	private Dictionary<IObserver, Product> observers = new();
	public void Register(IObserver observer,Product product)
	{
		observers.TryAdd(observer, product);
	}
	public void UnRegister(IObserver observer) 
	{
		observers.Remove(observer);
	}

	public void NotifyAll()
	{
		foreach(var kv in observers)
		{
			kv.Key.Notify(kv.Value);
		}
	}
	public void NotifyForProductName(string productName)
	{
		foreach (var kv in observers)
		{
			//isim kontrolü yapalım
			if(kv.Value.Name==productName)
		        kv.Key.Notify(kv.Value);

		}
	}
}

interface IObserver
{
    string FullName { get; set; }
	void Notify(Product product);
}

class ElvanObserver : IObserver
{
	//public string FullName { get; set; }

	public ElvanObserver(string fullName)
	{
		FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
	}
	public string FullName { get; set;}

	public void Notify(Product product)
	{
		Console.WriteLine($"{FullName},Product {product.Name} in stock now!");
	}
}
class YaseminObserver:IObserver
{
	public string FullName {  get; set; }

	public YaseminObserver(string fullName)
	{
		FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
	}

	public void Notify(Product product)
	{
		Console.WriteLine($"{FullName},Product {product.Name} in stock now!");
	}
}

class Product
{
	private string v;

	public string Name { get; set; }
	public decimal Price { get; set; }

	public Product(string name, decimal price)
	{
		Name = name;
		Price = price;
	}

	public Product(string v)
	{
		this.v = v;
	}
}