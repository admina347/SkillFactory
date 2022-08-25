/* Класс должен содержать целочисленные поля для сторон a и b.
Класс должен содержать метод Square, возвращающий площадь прямоугольника (произведение сторон).
Класс должен содержать 3 конструктора: с 2 параметрами, когда a != b, с 1 параметром, когда a == b, 
и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4. */

Rectangle Rectangle = new Rectangle(6);
int s;
s = Rectangle.Square();
Console.WriteLine(s);

class Rectangle
{
	public int a, b;

    public int Square()
    {
        return a * b;
    }
    // Конструктор 1
	public Rectangle()
	{
		a = 6;
        b = 4;
	}
	// Конструктор 2
	public Rectangle(int side)
	{
		a = side;
        b = side;
	}
	// Конструктор 3
	public Rectangle(int first, int second)
	{
		a = first;
        b = second;
	}
}