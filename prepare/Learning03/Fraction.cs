public class Fraction
{
    private float _top;
    private float _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 5;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public float GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public float GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}