# Documentation
### [_`Calculator.cs`_](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Calculator.cs)
This class calculate square of different figures. It have only one method with three overloads:
* `CalculateSquare`(_double **a**, double **b**, double **c**_)  
This overload calculate square of the **`triangle`** with given lengths of sides.
* `CalculateSquare`(_double **radius**_)  
This overload calculate square of the **`circle`** with given radius.
* `CalculateSquare`(_ISquareCalculable **squareCalculable**_)  
This overload calculate square of the any object wich implements
[`ISquareCalculable`](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/ISquareCalculable.cs) interface.

### [__`TriangleUtils.cs`__](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/TriangleUtils.cs)
This class created for determining if the triangle right-angled or not. It have one method with two overloads:
* `IsTriangleRight`(_Triangle **triangle**_)  
This overload determine if [`Triangle`](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/Triangle.cs) object right-angled or not.
* `IsTriangleRight`(_double **a**, double **b**, double **c**_)  
This overload determine if the **`triangle`** with given lengths of sides right-angled or not.

### [__`ISquareCalculable`__](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/ISquareCalculable.cs)
This interface have only one method `GetSquare()` which return square of the object.
### [__`Triangle.cs`__](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/Triangle.cs)
This class represents a triangle object. It have three public properties, which mean the lenghts of three sides of the triangle. It also implements
[`ISquareCalculable`](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/ISquareCalculable.cs) interface.
### [__`Circle.cs`__](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/Circle.cs)
This class represents a circle object. It have only one public property, which mean the length of the radius tof the circle. It also implements
[`ISquareCalculable`](https://github.com/SMarkls/TestTask/blob/master/TestTask.SquareCalculator/Figures/ISquareCalculable.cs) interface.
