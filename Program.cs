class Pen
{
	public string color;
	public int cost;
    // Конструктор 1
	public Pen()
	{
		color = "Черный";
		cost = 100;
	}
	// Конструктор 2
	public Pen(string penColor, int penCost)
	{
		color = penColor;
		cost = penCost;
	}
}