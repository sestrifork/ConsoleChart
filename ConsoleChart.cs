using System;
class ChartElement
{
	public int X {set; get;}
	public int Value {set;get;}
	public ConsoleColor Color {set;get;}

	public ChartElement(int TheX, int TheValue, ConsoleColor TheColor)
	{
		X = TheX;
		Value = TheValue;
		Color = TheColor;
	}
}

class ConsoleChart : ConsoleCanvas
{
	List<ChartElement> chartElements;

    public ConsoleChart() : base()
	{
		chartElements = new List<ChartElement>();
	}
	public void Add(ChartElement TheElement)
	{
		chartElements.Add(TheElement);
	}
	public void Add(int TheX, int TheValue, ConsoleColor TheColor)
	{
		Add(new ChartElement(TheX, TheValue, TheColor));
	}
	public void Show()
	{
		chartElements.ForEach(delegate(ChartElement element) 
		{
			Rect(new Point(element.X, Height-element.Value-1), 1, element.Value, element.Color);
		});
	}
}

