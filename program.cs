using System;

//Class1D A = new Class1D();
Class2D contacts = new Class2D();                   // Create an instance of Class2D

string op = "test";

firstScreen home = new firstScreen();
home.display(ref op);
home.menu(ref op, ref contacts);
