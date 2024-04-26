class Rectangle 
{
    public uint a, b;

    public Rectangle() 
    {
        a = 6;
        b = 4;
    }

    public Rectangle(uint  num) 
    {
        a = num;
        b = num;
    }

    public Rectangle(uint num1, uint num2) 
    {
        a = num1;
        b = num2;
    }

    public uint Square() 
    {
        return a * b;
    }
}