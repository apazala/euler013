using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        double sumd = 0.0;

        const Int32 BufferSize = 65536;
        string fileName = "data.txt";
        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    double b = Double.Parse(line);
                    sumd += b;
                }
            }
        }

        double lim = 1e10;
        while(sumd > lim)
            sumd*=.1;

        Console.WriteLine((long)sumd);

    }
}