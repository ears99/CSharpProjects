/*
  Written by Jacob Seadorf (Assignment 9-5)
  TASK 1: The car class can be initialized and returns the model of the car
  TASK 2: The car class can be initialized and returns the miles per gallon of the car
  TASK 3: Overload the ++ operator for the Car class
*/


using System;
using static System.Console;
using System.Globalization;

class Car {
	public Car(string model, int milesPerGallon) {
		this.model = model;
		this.milesPerGallon = milesPerGallon;
	}

	public Car(string model) {
		this.model = model;
		milesPerGallon = 20;
	}


	public static Car operator ++(Car c) {
    c.milesPerGallon++;
	return c;
}

public int milesPerGallon;
public string model;


public void DisplayInfo() {
		WriteLine("Model: " + model);
		WriteLine("Miles per gallon: " + milesPerGallon);
	}

}

class CarDemo {
	static void Main() {
		Car c1 = new Car("Ford Focus", 12);
		Car c2 = new Car("Kia Soul");

		WriteLine("Before incrementation: ");
		c1.DisplayInfo();
		c2.DisplayInfo();
		WriteLine();
		c1++;
		c2++;

		WriteLine("After Incrementation");
		c1.DisplayInfo();
		c2.DisplayInfo();

	}
}
