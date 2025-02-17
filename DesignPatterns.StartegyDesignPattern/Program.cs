﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography.X509Certificates;

var paymentOptions=new PaymentOptions()
{
    CardNumber="1232435454656565",
    CardHolderName="Yasemin Elvan",
    ExpirationDate="12/25",
    Amount=1000
};



var paymentService = new PaymentService();

do
{
    Console.WriteLine("Ödeme yapılacak bankayı seçiniz (1:Garanti,2:Yapı Kredi,3:İş Bankası):");
    var bank=Console.ReadLine();

    IPaymentService bankPaymentService = null;

    switch (bank)
    {
        case "1":
            bankPaymentService=new GarantiBankPaymentService();
            break;
        case "2":
            bankPaymentService =new YapiKrediBankPaymentService();
            break;
        case "3": 
            bankPaymentService=new IsBankasiBankPaymentService();
            break;
        default:
            Console.WriteLine("Gecersiz Banka Seçimi");
            break;
    }
    paymentService.SetPaymentService(bankPaymentService);
    paymentService.PayViaStrategy(paymentOptions);
} while (Console.ReadKey().Key != ConsoleKey.Escape);
class PaymentService
{

    private IPaymentService paymentService;

    public PaymentService() { }
	public PaymentService(IPaymentService paymentService)
	{
		this.paymentService = paymentService;
	}
    public void SetPaymentService(IPaymentService paymentService)
    {
        this.paymentService=paymentService;
    }

	public bool PayViaStrategy(PaymentOptions options)
    {
       return paymentService.Pay(options);
    }
}

public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Garanti bankası ile ödeme yapıldı");
        return true;
    }
}

public class YapiKrediBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Yapı Kredi ile ödeme yapıldı");
        return true;
    }
}

public class IsBankasiBankPaymentService:IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("İş bankası ile ödeme yapıldı");
        return true;
    }
}
interface IPaymentService
{
	bool Pay(PaymentOptions paymentOptions);
}

public class PaymentOptions
{
    public string CardNumber { get; set; }
    public string  CardHolderName{ get; set; }
    public string ExpirationDate { get; set; }
    public string Cvv { get; set; }

    public decimal Amount { get; set; }
}