using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base (color)
    {
        _length = length;
        _width = width;
    } 

    public Rectangle(string color) : base (color)
    {
       
    } 

    // public string GetColor()
    // {
    //     return base.GetColor();
    // }

    public override double GetArea()
    {
        return _length * _width;
    }
}