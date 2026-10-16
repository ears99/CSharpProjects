/*
  Assignment 9-3
  TASK 1: Overload the + operator
  TASK 2: Create three SalesTransactin constructor methods.
*/

using System;
using static System.Console;
using System.Globalization;
using System.Numerics;

class SalesTransaction { 
	public SalesTransaction(string name, double salesAmount, double rate) {
		Name = name;
		this.salesAmount = salesAmount;
		//_commission = commission;
		RATE = rate;
		commission = salesAmount * RATE;

/*		WriteLine("The name is " + name);
		WriteLine("The sales amount is: " + salesAmount); */

		

	}
	public SalesTransaction(string name, double salesAmount) {
		Name = name;
		this.salesAmount = salesAmount;
//		_commission = 0;
		RATE = 0;
		commission = salesAmount * RATE;
/*
		WriteLine("The name is " + name);
		WriteLine("The sales amount is: " + salesAmount);
*/
	}
	public SalesTransaction(string name) {
		Name = name;
		salesAmount = 0;
		commission = 0;
		RATE = 0;
		//WriteLine("The name is: " + name);
	}
	

	//overload the plus operator to add the sales 
	//values for two SalesTransaction objects
	public static SalesTransaction operator +(SalesTransaction st1, SalesTransaction st2)
	{
		return new SalesTransaction(" ", st1.getSalesAmount() + st2.getSalesAmount());
	}

	public double getRate() { return RATE; }
	public double getSalesAmount() { return salesAmount; }
	public string getName() { return Name; }
	public double getCommission() {return commission; }
	private readonly double RATE;
	private double salesAmount;
	private string Name;
	private double commission;
}

class SalesTransactionDemo {
	static void Main() {
		SalesTransaction st1 = new SalesTransaction("Jeff", 100.0, 0.5);
		SalesTransaction st2 = new SalesTransaction("Dave", 150.0);
		SalesTransaction st3 = new SalesTransaction("Bob");

		SalesTransaction st4 = st2 + st1;
		WriteLine("The name is " + st1.getName() + ", the sales amount is " + st1.getSalesAmount().ToString("C", CultureInfo.GetCultureInfo("en-US")) + " the commssion is " + st1.getCommission().ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("The name is " + st2.getName() + ", the sales amount is " + st2.getSalesAmount().ToString("C", CultureInfo.GetCultureInfo("en-US")) + " the commission is " + st2.getCommission().ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("The name is " + st3.getName() + ", the sales amount is " + st3.getSalesAmount().ToString("C", CultureInfo.GetCultureInfo("en-US")) + " the commission is " + st3.getCommission().ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("The name is " + st4.getName() + ", the sales amount is " + st4.getSalesAmount().ToString("C", CultureInfo.GetCultureInfo("en-US")) + " the commission is " + st4.getCommission().ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
