/*
  Written by Jacob Seadorf (Assignment 9-6A)
  TASK 1: Sales class defined correctly (gives me the usual AssertionError)
  TASK 2: Correct program execution (I know I won't get this one, this one gives me a stack overflow error)
*/

using System;
using static System.Console;
using System.Globalization;

class Sale {

	private string inventoryNumber;
	private double amount;
	private double tax;

	public string InventoryNumber {
		get { return InventoryNumber; }
		set { InventoryNumber = value; }
	}

	public double Amount {
		get { return amount; }
		set {
			if(amount <= 100) {
				tax = amount * 0.08;
			} else { tax = (100 * 0.08) + ((amount - 100) * 0.06); }
		}
	}

	public double Tax {
		get { return tax; }
	}

}


class SalesTaxDemo {
	static void Main() {
		Sale[] s = new Sale[10];
		for(int i = 0; i < s.Length; i++) {
			s[i] = new Sale(); 
			Write("Enter inventory #" + (i + 1) + " >> ");
			s[i].InventoryNumber = ReadLine();
			Write("Enter amount of sale >> ");
			s[i].Amount = Convert.ToDouble(ReadLine());
		}

		for(int i = 0; i < s.Length; i++) {
			WriteLine("Sale #" + (i + i) + " Amount: " + (i + 1) + " Sale " + s[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
			WriteLine("\t Tax is " + s[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		}
	}
}
