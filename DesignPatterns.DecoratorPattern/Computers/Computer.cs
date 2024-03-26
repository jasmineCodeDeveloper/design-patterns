using DesignPatterns.DecoratorPattern.Computers;
using System;
using System.Diagnostics;

namespace DesignPatterns.DecoratorPattern.Computers
{
	//1950 yıllar bilgisayar
	public class Computer
	{
		public void Start()
		{
			Console.WriteLine($"{GetType().Name} is starting");
		}
		public void ShutDown()
		{
			Console.WriteLine($"{GetType().Name} is shutting down");
		}
	}
}
//1970 yıllar bilgisayar

public class Laptop : Computer
{
	public void OpenLid()
	{

		Debug.WriteLine($"{GetType().Name}'s lid is opening");
	}
	public void CloseLid() 
	{
		Debug.WriteLine($"{GetType().Name}'s lid is closing");
	}
}

//laptopları decaoretor etmek için türetecek olduğum class'dır
//yeni oluşacak laptoplarımı türetecek olduğum classdır
public class LaptopDecorator : Laptop
{
	public virtual void OpenLid()
	{

		base.OpenLid();
	}
	public virtual void CloseLid()
	{
		base.CloseLid();
	}

}



//1990's yıllar
public class DellLaptop:LaptopDecorator
{
	public override void CloseLid()
	{
		base.CloseLid();
		Debug.WriteLine("Dell Laptop is sleeping");
	}
	public override void OpenLid()
	{
		Console.WriteLine("Dell Laptop is waking up");
		base.OpenLid();
	}

}


public class AppleLaptop : LaptopDecorator
{
	//public void OpenLid()
	//{

	//	base.OpenLid();
	//}
	//public void CloseLid()
	//{
	//	base.CloseLid();
	//}
}