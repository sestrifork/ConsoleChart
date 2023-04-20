// See https://aka.ms/new-console-template for more information
ConsoleChart chart = new ConsoleChart();
Random randomizer = new Random();

BasicLogger.WriteLog("The programming is starter up...");

chart.DrawMaxFrame();

for (int i=1; i<chart.Width-1; i=i+4) {
    int value = randomizer.Next(1, chart.Height-4);
    ConsoleColor color = ConsoleColor.Green;
    if (value < chart.Height/2) {
        color = ConsoleColor.Red;
    }

    chart.Add(i, value, color);
}
chart.Show();
Console.ReadKey();