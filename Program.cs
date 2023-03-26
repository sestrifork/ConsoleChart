// See https://aka.ms/new-console-template for more information
ConsoleCanvas consoleCanvas = new ConsoleCanvas();

consoleCanvas.DrawMaxFrame();
for (int i=1; i<consoleCanvas.Width; i=i+4) {
    int value = i * 42 % consoleCanvas.Height;
    ConsoleColor color = ConsoleColor.Green;
    if (value < consoleCanvas.Height/2) {
        color = ConsoleColor.Red;
    }
    consoleCanvas.Rect(new Point(i,consoleCanvas.Height-value-1),1,value, color);
}
Console.ReadKey();
