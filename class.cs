using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // to calculate run time


public class Class1D
    {
        public int capacity;
        public int count;
        public int[] array;

        public Class1D() 
        {
            capacity = 3;
            count = 0;
            array = new int[capacity];
        }
        public void Add(int value)
        {
            if (count< capacity)
            {
               array[count] = value;
                count++;
            }

            else
            {
                capacity = capacity * 2;
                int[] temp = new int[capacity];

                for(int i=0 ; i<count ; i++)
                {
                    temp[i] = array[i];
                }
                temp[count] = value;
                array = temp;
                count++;

            }

            
        }


        public void Print()
        {
            for(int i = 0;i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
}

    // Contacts Class
   

    public class Class2D
    {
        public int rows;
        public int columns;
        public int count;
        public string[,] table;

        // Constructor
        public Class2D()
        {
            rows = 3;
            columns = 4;
            count = 0;
            table = new string[rows, columns];
        }

        // Method to return the number of rows in the 2D array
        public int CountRows()
        {
            return table.GetLength(0);  // GetLength(0) returns the number of rows in the 2D array
        }

        /*---------------------------------------------------------------------------------------------------------------------------*/
        /* CRUD Section Open */

        // Add Contacts
        public void Add(string Cname, string Ctpno, string Cgroup, string Ccity)
        {
            if (count < rows)
            {
                table[count, 0] = Cname;
                table[count, 1] = Ctpno;
                table[count, 2] = Cgroup;
                table[count, 3] = Ccity;
                count++;
            }
            else
            {
                rows = rows * 2;
                string[,] temp = new string[rows, columns];

                for (int i = 0; i < count; i++)
                {
                    temp[i, 0] = table[i, 0];
                    temp[i, 1] = table[i, 1];
                    temp[i, 2] = table[i, 2];
                    temp[i, 3] = table[i, 3];
                }
                temp[count, 0] = Cname;
                temp[count, 1] = Ctpno;
                temp[count, 2] = Cgroup;
                temp[count, 3] = Ccity;
                table = temp;
                count++;
            }
        }

        // Print Contacts
        public void Print() // Print Contacts
        {
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)

        // Calculate left padding to center-align the table
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);

            string separator = new string('-', tableWidth);

        // Print the header with column names
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);

        // Print the table data in a nicely aligned way
        for (int i = 0; i < count; i++)
            {
                Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
            }
        }
        // Delete Contacts
        public void delete(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (table[i, 0] == name)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        table[j, 0] = table[j + 1, 0];
                        table[j, 1] = table[j + 1, 1];
                        table[j, 2] = table[j + 1, 2];
                        table[j, 3] = table[j + 1, 3];
                    }
                    count--;
                    break;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Contact deleted successfully!");
        }

        // Update Contacts
        public void update(string name)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < count; i++)
            {
                
                if (table[i, 0] == name)
                {
                    Console.Write("Enter new Name           : ");
                    table[i, 0] = Console.ReadLine();
                    Console.Write("Enter new Phone Number   : ");
                    table[i, 1] = Console.ReadLine();
                    Console.Write("Enter new Group          : ");
                    table[i, 2] = Console.ReadLine();
                    Console.Write("Enter new City           : ");
                    table[i, 3] = Console.ReadLine();
                    break;
                }
            }
        }

        /* CRUD Section Close */
        /*---------------------------------------------------------------------------------------------------------------------------*/


        /*---------------------------------------------------------------------------------------------------------------------------*/
        /* Searching Section Open by linear search */

        // Search Contacts by Name (Default)           linear search
        public void searchname    (string name)
        {
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
            string separator = new string('-', tableWidth);
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);
            for (int i = 0; i < count; i++)
            {
                
                if (table[i, 0] == name)
                {
                    
                    Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                }
            }
            Console.WriteLine(" ");
        }

        // Search Contacts by Group                    linear search
        public void searchgroup(string group)
        {
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
            string separator = new string('-', tableWidth);
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);

            for (int i = 0; i < count; i++)
            {
                if (table[i, 2] == group)
                {
                   Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                
                }
            }
            Console.WriteLine(" ");
        }

        // Search Contacts by City                     linear search
        public void searchcity(string city)
        {
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
            string separator = new string('-', tableWidth);
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);

            for (int i = 0; i < count; i++)
            {
                if (table[i, 3] == city)
                {
                     Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                
                }
            }
            Console.WriteLine(" ");
        }

        // Search Contacts by Phone Number             linear search
        public void searchphone(string phone)
        {
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
            string separator = new string('-', tableWidth);
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);
            for (int i = 0; i < count; i++)
            {
                if (table[i, 1] == phone)
                {
                    Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                
                }
            }
            Console.WriteLine(" ");
        }

     /*  // Search Contacts by Group and Copy           linear search
        public void search_and_copybygroup(string group)
        {
            string[,] temp = new string[rows, columns];
            int tempcount = 0;

            for (int i = 0; i < count; i++)
            {
                if (table[i, 2] == group)
                {
                    temp[tempcount, 0] = table[i, 0];
                    temp[tempcount, 1] = table[i, 1];
                    temp[tempcount, 2] = table[i, 2];
                    temp[tempcount, 3] = table[i, 3];
                    tempcount++;
                }
            }

            Console.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string('-', 65)); // Add a separator line for better readability

            for (int i = 0; i < tempcount; i++)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}",
                temp[i, 0], temp[i, 1], temp[i, 2], temp[i, 3]);
            }
        }

        // Search Contacts by City and Copy             linear search
        public void search_and_copybycity(string city) 
        {
            string[,] temp = new string[rows, columns];
            int tempcount = 0;

            for (int i = 0; i < count; i++)
            {
                if (table[i, 3] == city)
                {
                    temp[tempcount, 0] = table[i, 0];
                    temp[tempcount, 1] = table[i, 1];
                    temp[tempcount, 2] = table[i, 2];
                    temp[tempcount, 3] = table[i, 3];
                    tempcount++;
                }
            }

            Console.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string('-', 65)); // Add a separator line for better readability

            for (int i = 0; i < tempcount; i++)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}",
                    temp[i, 0], temp[i, 1], temp[i, 2], temp[i, 3]);
            }
        }

*/
    /* Searching Section Close by linear search */




    /* Searching Section Open by binear search */
    /*=============================================================================================================================================================================*/
        private void SortByName()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(table[j, 0], table[j + 1, 0], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap rows
                        for (int k = 0; k < columns; k++)
                        {
                            string temp = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = temp;
                        }
                    }
                }
            }
        }
        public void BinarySearchByName(string name) 
{
    SortByName();
    int left = 0, right = count - 1;
    int consoleWidth = Console.WindowWidth; // Get the console width
    int tableWidth = 65; // Total table width (adjusted for column formatting)
    int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        int compare = string.Compare(table[mid, 0], name, StringComparison.OrdinalIgnoreCase);

        if (compare == 0)
        {
            // Contact found, print details with proper padding
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", 
                "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + new string('-', tableWidth)); // Add separator line
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", 
                table[mid, 0], table[mid, 1], table[mid, 2], table[mid, 3]);
            return;
        }
        else if (compare < 0)
        {
            left = mid + 1; // Search right half
        }
        else
        {
            right = mid - 1; // Search left half
        }
    }

    Console.WriteLine(new string(' ', leftPadding) + "Contact not found.");
}

    /*=============================================================================================================================================================================*/
        private void SortByGroup()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(table[j, 2], table[j + 1, 2], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap rows
                        for (int k = 0; k < columns; k++)
                        {
                            string temp = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = temp;
                        }
                    }
                }
            }
        }

        public void BinarySearchByGroup(string group)
{
    SortByGroup(); // Ensure the table is sorted by Group before searching

    int left = 0, right = count - 1;
    int firstMatch = -1, lastMatch = -1;

    // Binary search to find one occurrence
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        int compare = string.Compare(table[mid, 2], group, StringComparison.OrdinalIgnoreCase);

        if (compare == 0)
        {
            firstMatch = lastMatch = mid;

            // Expand left to find first matching element
            while (firstMatch > 0 && string.Compare(table[firstMatch - 1, 2], group, StringComparison.OrdinalIgnoreCase) == 0)
                firstMatch--;

            // Expand right to find last matching element
            while (lastMatch < count - 1 && string.Compare(table[lastMatch + 1, 2], group, StringComparison.OrdinalIgnoreCase) == 0)
                lastMatch++;

            break;
        }
        else if (compare < 0)
        {
            left = mid + 1; // Search right half
        }
        else
        {
            right = mid - 1; // Search left half
        }
    }

    // If no match is found
    if (firstMatch == -1)
    {
        Console.WriteLine("\nNo contacts found in Group: " + group);
        return;
    }

    // Print all matching contacts
    Console.WriteLine($"\nContacts found in Group: {group}");

    int consoleWidth = Console.WindowWidth; // Get the console width
    int tableWidth = 65; // Total table width (adjusted for column formatting)
    int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
    
    string padding = new string(' ', leftPadding);
    string separator = new string('-', tableWidth);

    Console.WriteLine(padding + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
    Console.WriteLine(padding + separator);

    for (int i = firstMatch; i <= lastMatch; i++)
    {
        Console.WriteLine(padding + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
    }
}


    /*=============================================================================================================================================================================*/


    private void SortByCity()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (string.Compare(table[j, 3], table[j + 1, 3], StringComparison.OrdinalIgnoreCase) > 0)
                {
                    // Swap rows
                    for (int k = 0; k < columns; k++)
                    {
                        string temp = table[j, k];
                        table[j, k] = table[j + 1, k];
                        table[j + 1, k] = temp;
                    }
                }
            }
        }
    }

    public void BinarySearchByCity(string city)
    {
        SortByCity(); // Ensure the table is sorted by City before searching

        int left = 0, right = count - 1;
        int firstMatch = -1, lastMatch = -1;

        // Binary search to find one occurrence
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int compare = string.Compare(table[mid, 3], city, StringComparison.OrdinalIgnoreCase);

            if (compare == 0)
            {
                firstMatch = lastMatch = mid;

                // Expand left to find first matching element
                while (firstMatch > 0 && string.Compare(table[firstMatch - 1, 3], city, StringComparison.OrdinalIgnoreCase) == 0)
                    firstMatch--;

                // Expand right to find last matching element
                while (lastMatch < count - 1 && string.Compare(table[lastMatch + 1, 3], city, StringComparison.OrdinalIgnoreCase) == 0)
                    lastMatch++;

                break;
            }
            else if (compare < 0)
            {
                left = mid + 1; // Search right half
            }
            else
            {
                right = mid - 1; // Search left half
            }
        }

        // If no match is found
        if (firstMatch == -1)
        {
            Console.WriteLine("-No contacts found in City: " + city);
            return;
        }

        // Print all matching contacts
            int consoleWidth = Console.WindowWidth; // Get the console width
            int tableWidth = 65; // Total table width (adjusted for column formatting)
            int leftPadding = Math.Max(0, (consoleWidth - tableWidth) / 2);
            string separator = new string('-', tableWidth);
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
            Console.WriteLine(new string(' ', leftPadding) + separator);

        for (int i = firstMatch; i <= lastMatch; i++)
        {
            Console.WriteLine(new string(' ', leftPadding) + "{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
            
        }
    }
    /*=============================================================================================================================================================================*/

    /* Searching Section close by binear search */

    /*---------------------------------------------------------------------------------------------------------------------------*/

    // Export Contacts
    public void export()                                                            //Export Contacts
        {
            string path = @"C:\Users\user\Desktop\Contacts.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}", "Name", "Phone Number", "Group", "City");
                file.WriteLine(new string('-', 65)); // Add a separator line for better readability

                for (int i = 0; i < count; i++)
                {
                    file.WriteLine("{0,-20} {1,-15} {2,-10} {3,-20}", table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                }
            }
        }
        // Import Data from text file
    public void load_data_fromtxt()
{
    string path = @"C:\Users\user\Desktop\Contacts.txt";

    // Read all lines from the file
    string[] lines = System.IO.File.ReadAllLines(path);

    // Start processing from the 3rd line (assuming the first two lines are headers)
    for (int i = 2; i < lines.Length; i++)
    {
        // Split the line into columns using a fixed-width approach or a more reliable delimiter
        string[] words = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Ensure the array has enough rows to accommodate new data
        if (count >= rows)
        {
            rows *= 2; // Double the size of rows
            string[,] temp = new string[rows, columns];

            // Copy existing data to the new array
            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    temp[j, k] = table[j, k];
                }
            }
            table = temp;
        }

        // Add the imported data to the dynamic array
        table[count, 0] = words[0]; // Name
        table[count, 1] = words[1]; // Phone Number
        table[count, 2] = words[2]; // Group
        table[count, 3] = words[3]; // City
        count++;
    }
    }

        /*---------------------------------------------------------------------------------------------------------------------------
           Sorting Functions 
          ---------------------------------------------------------------------------------------------------------------------------*/

        // 1) Bubble Sort
        public void BubbleSort()
        {
            // Measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    // Compare table[j, 0] and table[j+1, 0]
                    if (String.Compare(table[j, 0], table[j + 1, 0]) > 0)
                    {
                        // Swap the entire row
                        for (int k = 0; k < columns; k++)
                        {
                            string temp = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = temp;
                        }
                    }
                }
            }

            stopwatch.Stop();
            UI uI1 = new UI();
            uI1.Center($"Runtime: {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine();
        }

        // 2) Insertion Sort
        public void InsertionSort()
        {
             // Measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < count; i++)
            {
                // Save the current row in temporary variables
                string keyName = table[i, 0];
                string keyPhone = table[i, 1];
                string keyGroup = table[i, 2];
                string keyCity = table[i, 3];

                int j = i - 1;

                // Move elements of table[0..i-1] that are greater than keyName
                // to one position ahead of their current position
                while (j >= 0 && String.Compare(table[j, 0], keyName) > 0)
                {
                    table[j + 1, 0] = table[j, 0];
                    table[j + 1, 1] = table[j, 1];
                    table[j + 1, 2] = table[j, 2];
                    table[j + 1, 3] = table[j, 3];
                    j--;
                }

                // Place the saved row at the correct position
                table[j + 1, 0] = keyName;
                table[j + 1, 1] = keyPhone;
                table[j + 1, 2] = keyGroup;
                table[j + 1, 3] = keyCity;
            }
            stopwatch.Stop();
            UI uI1 = new UI();
            uI1.Center($"Runtime: {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine();
        }

        // 3) Selection Sort
        public void SelectionSort()
        {
            // Measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < count - 1; i++)
            {
                // Find the minimum element in table[i..count-1]
                int minIndex = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (String.Compare(table[j, 0], table[minIndex, 0]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum row with the i-th row
                if (minIndex != i)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        string temp = table[i, k];
                        table[i, k] = table[minIndex, k];
                        table[minIndex, k] = temp;
                    }
                }
            }
            stopwatch.Stop();
            UI uI1 = new UI();
            uI1.Center($"Runtime: {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine();
        }

        // 4) Quick Sort
        public void QuickSort()
        {
            // Measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            QuickSortHelper(0, count - 1);

            stopwatch.Stop();
            UI uI1 = new UI();
            uI1.Center($"Runtime: {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine();
        }

        private void QuickSortHelper(int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(low, high);
                QuickSortHelper(low, pivotIndex - 1);
                QuickSortHelper(pivotIndex + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            // Choose the rightmost element as pivot
            string pivot = table[high, 0];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // If current element is smaller than pivot
                if (String.Compare(table[j, 0], pivot) < 0) 
                {
                    i++;
                    // Swap entire rows i and j
                    for (int k = 0; k < columns; k++)
                    {
                        string temp = table[i, k];
                        table[i, k] = table[j, k];
                        table[j, k] = temp;
                    }
                }
            }

            // Swap the pivot row with row (i+1)
            int pivotIndex = i + 1;
            for (int k = 0; k < columns; k++)
            {
                string temp = table[pivotIndex, k];
                table[pivotIndex, k] = table[high, k];
                table[high, k] = temp;
            }

            return pivotIndex;
        }



        // 5) Merge Sort
        public void MergeSort()
        {
            // Measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            MergeSortHelper(0, count - 1);

            stopwatch.Stop();
            UI uI1 = new UI();
            uI1.Center($"Runtime: {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine();

        }

        private void MergeSortHelper(int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(left, mid);
                MergeSortHelper(mid + 1, right);
                Merge(left, mid, right);
            }
        }

        private void Merge(int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            string[,] L = new string[n1, columns];
            string[,] R = new string[n2, columns];

            // Copy data to temp arrays L and R
            for (int i = 0; i < n1; i++)
            {
                for (int c = 0; c < columns; c++)
                {
                    L[i, c] = table[left + i, c];
                }
            }

            for (int j = 0; j < n2; j++)
            {
                for (int c = 0; c < columns; c++)
                {
                    R[j, c] = table[mid + 1 + j, c];
                }
            }

            // Merge the temp arrays back into table[left..right]
            int iIndex = 0;  // Initial index of first subarray
            int jIndex = 0;  // Initial index of second subarray
            int k = left;    // Initial index of merged subarray

            while (iIndex < n1 && jIndex < n2)
            {
                if (String.Compare(L[iIndex, 0], R[jIndex, 0]) <= 0)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        table[k, c] = L[iIndex, c];
                    }
                    iIndex++;
                }
                else
                {
                    for (int c = 0; c < columns; c++)
                    {
                        table[k, c] = R[jIndex, c];
                    }
                    jIndex++;
                }
                k++;
            }

            // Copy the remaining elements of L[], if there are any
            while (iIndex < n1)
            {
                for (int c = 0; c < columns; c++)
                {
                    table[k, c] = L[iIndex, c];
                }
                iIndex++;
                k++;
            }

            // Copy the remaining elements of R[], if there are any
            while (jIndex < n2)
            {
                for (int c = 0; c < columns; c++)
                {
                    table[k, c] = R[jIndex, c];
                }
                jIndex++;
                k++;
            }
        }
    }

