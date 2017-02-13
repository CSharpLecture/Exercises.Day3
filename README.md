# Exercises.Day3

Exercises and solutions for the third day.

## 11. Extending existing classes

Create a class called `MyRandom`, which derives from the .NET class `Random`, but returns different values. Implement a new method called `Next()` and a possibility to access the `protected` method `Sample()` from outside.

## 12. A simple but useful structure

Create a structure called `Point3`, which contains 3 (private) `float` variables called *x*, *y* and *z*. Create a property for each variable. Changing a variable (setting it) should result in output on the console. The output has to tell us which variable changed and what changed (old value, new value).

Look up the syntax for overloading the addition operator `+` (look it up by viewing the meta data (definition) of e.g. the `decimal` structure). Implement it for your structure.

Finally use your structure in a new version of your calculator. This time not integers, but `Point3`s will be used.

## 13. Vehicle, Car, ...

Start by creating an `abstract` class called `Vehicle`. Create two `abstract` methods called `Accelerate()` and `Brake()`. Additionally you should place an (protected) integer variable called `tires`. Add a property called `Tire`, which defines a `get` block for the variable.

Derive a class called `Car` from `Vehicle`. Implement the two functions in such a way, that they display the state change like "The car is is accelerating" or "The car is braking" on the console. Additionally extend the class with an integer property called `Gears` (with `get` and `set`) and set the value of `tires` to 4.

Finally derive from `Car` and call the new class `Porsche`. Override the method `Accelerate()` with some string that might represent your attitude towards driving a Porsche.

## 14. Let's create a copy

Extend the class `Car` of assignment 13 with a copy-constructor, i.e. a constructor which takes an instance of the own class as input parameter, and uses this instance to create a (usually deep) copy of all fields.

Also override the method `Equals()` in a way that it is possible to compare one instance of the class `Car` with another for equality.

Finally try to cast an instance of your `Car` class to the `Porsche` class. Why is this not possible?

## 15. (**MP**) Write a class for (2D) plotting

Write a project that makes storing plot-data in C# objects possible. The project has to fulfill the following requirements:

* An arbitrary amount of data series should be storable.
* Each series consists of an arbitrary amount of data points.
* Each data point consists of an X and a Y value.
* Each series contains information about the min x and y, as well as max x and y values.
* Each series has a label and a color (just a string) assigned.

The project aims to be very generic, such that the created plotting class construct could be used with various renderes. A renderer is a special class, which takes some input, analyzes it and starts streaming some output in a certain form. In this case you could input an instance of your plotting class into some renderer, which would transform it to e.g. HTML output, displaying something on the console or a bitmap image.

## License
This work is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).
