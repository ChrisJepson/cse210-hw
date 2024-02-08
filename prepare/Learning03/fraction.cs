using System;

public class Fraction{

    private int _top;
    private int _bottom;

    public Fraction(){ //set defaults for _top and _bottom to 1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){//if a whole number is placed in the input it puts it over 1
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){ //makes a fraction out of 2 numbers
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString(){
        string fractionstring = $"{_top}/{_bottom}";
        return fractionstring;
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }




}