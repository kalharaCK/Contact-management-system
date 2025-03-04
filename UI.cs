using System;

public class UI
{
    //Logo Function
    public void logo()  // display the logo
    {
        string text = @" ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔═╗╔╦╗    ╔╦╗╔═╗╔╗╔╔═╗╔═╗╔═╗╦═╗
 ║  ║ ║║║║ ║ ╠═╣║   ║     ║║║╠═╣║║║╠═╣║ ╦║╣ ╠╦╝
╚═╝╚═╝╝╚╝ ╩ ╩ ╩╚═╝ ╩     ╩ ╩╩ ╩╝╚╝╩ ╩╚═╝╚═╝╩╚═";

        // Set the font color to green
        Console.ForegroundColor = ConsoleColor.Green;

        // Get the console width
        int consoleWidth = Console.WindowWidth;

        // Split the text into lines
        string[] lines = text.Split('\n');

        // Center each line and print it
        foreach (var line in lines)
        {
            // Calculate the left padding to center the text, ensuring padding isn't negative
            int padding = Math.Max(0, (consoleWidth - line.Length) / 2);
            Console.WriteLine(line.PadLeft(padding + line.Length));
        }

        // Reset the console color to the default color after printing
        Console.ResetColor();
    }
    


    // Display line function (-------------....)
    public void line(){     // display line
        Console.WriteLine(new string('-', Console.WindowWidth));
    }



    // Function that clears the Console screen
    public void ClearScreen()   // screen clear
    {
        Console.Clear();
    }



    // Make and print vertical list
    public void ListMaker(int numElements, List<string> items) 
    {
        if (items.Count != numElements)
        {
            Console.WriteLine("Error: The number of items does not match the specified number of elements.");
            return;
        }

        // Find the maximum length of the items
        int maxLength = 0;
        foreach (var item in items)
        {
            if (item.Length > maxLength)
                maxLength = item.Length;
        }

        // Get the console width for dynamic alignment
        int consoleWidth = Console.WindowWidth;

        foreach (var item in items)
        {
            int totalPadding = Math.Max(0, consoleWidth - maxLength); // Ensure no negative padding
            int leftPadding = totalPadding / 2;

            // Center-align and print the item
            Console.WriteLine(item.PadLeft(item.Length + leftPadding));
        }
        
    }



    // make and print horizontal list
    public void ListBar(int numElements, List<string> items)    
    {
        if (items.Count != numElements)
        {
            Console.WriteLine("Error: The number of items does not match the specified number of elements.");
            return;
        }

        // Combine the items into a horizontal list with separators
        string horizontalList = string.Join(" | ", items);

        // Print the horizontal list
        
        Console.WriteLine(horizontalList);
    }



    // loading animation
    public void ShowLoadingAnimation(string message, int durationInSeconds)     
    {
        // Set console text color to green
        Console.ForegroundColor = ConsoleColor.Green;

        // Display the message
        Console.Write(message + " ");

        // Define the animation frames
        char[] animationFrames = { '|', '/', '-', '\\' };

        // Calculate the end time
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        int frameIndex = 0;

        while (DateTime.Now < endTime)
        {
            // Display the next frame
            Console.Write(animationFrames[frameIndex]);
            
            // Move the cursor back to overwrite the frame
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

            // Update the frame index
            frameIndex = (frameIndex + 1) % animationFrames.Length;

            // Wait for a short time before showing the next frame
            Thread.Sleep(100);
        }

        // Reset the text color to default
        Console.ResetColor();

        // Finish the animation
       
    }



    // center the text
    public void Center(string txt)    
    {
        int width = Console.WindowWidth;
        int len = txt.Length;
        int left = (width - len) / 2;
        Console.WriteLine(txt.PadLeft(left + len));
    }
   

}
