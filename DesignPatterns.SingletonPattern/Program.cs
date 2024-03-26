// See https://aka.ms/new-console-template for more information
using DesignPatterns.SingletonPattern;

//Console.WriteLine("Hello, World!");
/*ensure single intance(can be use for memory caching)
 * bir objeden sadece tek bir instance oluşturmak istiyorsak,property istediğimiz gibi ulaşabilmek için sigleton pattern kullanırız
globaly access
created only when requested(obejeleri sadece kullanmak istersek create ederiz)*/
/*dezavantajları
 * test edilmesi zor
 * multithreading bir uygulama oluşturuyorsak her uygulama kendi instance oluşturmalıdır.
 **/




//await CountryProvider.Instance.GetCountries();

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries=await CountryProvider.Instance.GetCountries();

/*foreach (var country in countries)
{

	Console.WriteLine(country.Name);
}*/

//another service

//var countryProvider1 = new CountryProvider();

var countries1 = await CountryProvider.Instance.GetCountries();
Console.WriteLine(CountryProvider.Instance.CountryCount);

Console.WriteLine(DateTime.Now.ToLongTimeString());