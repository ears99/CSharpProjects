/*
  Written by Jacob Seadorf (Assignment 9-4)

  NOTE TO INSTRUCTOR: I'm still getting the Cengage error "str -- AssertionError: Cannot run tests".
  This is why I've decided to put my code in a Github repository. 

  TASK 1: The room class calculates and returns its area. 
  TASK 2: The room class calculates and returns the number of gallons required to paint the room.
*/

using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


class Room {
	public Room(int length, int width, int height) {
		_length = length;
		_width = width;
		_height = height;
		area = getArea();
		gallons = getGallons();
	}


	public readonly int area;
	public readonly int gallons; //one gallon covers 350 sq ft

	private int _length;
	private int _width;
	private int _height; //height of ceilings

	private int getArea() { return _length * _width * _height; }

	private int getGallons() {
		int paintNeeded = getArea() / 350; //number of gallons per 350sqft
		if(paintNeeded % 350 != 0) {
			paintNeeded = (getArea() / 350) + 1;
		}
		return paintNeeded;
	}
}

class PaintingDemo {
	static void Main() {
		Room r = new Room(12, 3, 10);
		WriteLine("The area of the room is: " + r.area + " square feet.");
		WriteLine("Gallons needed: " + r.gallons);
	}
}
