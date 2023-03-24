internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            StreamReader fIn = new(@"C:\Users\ilruz\Love.txt");

            string[] elements = fIn.ReadToEnd().Split(',');

            foreach (var i in elements)
                Console.WriteLine(i);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OutOfMemoryException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}