using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public static class BasicLogger 
{
    public static void WriteLog(string message) 
    {
        string logPath = "log.txt";
        
        using (StreamWriter writer = new StreamWriter(logPath, true))
        {
            writer.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}