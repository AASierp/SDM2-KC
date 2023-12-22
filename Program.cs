using SDM2_KC;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<UserCar>();
        for (int i = 0; i < numberOfRecords; i++)
        {
   
            var userCar = new UserCar();

            Console.WriteLine("Vehicle Brand: ");
            userCar.brand = Console.ReadLine();

            Console.WriteLine("Vehicle Model: ");
            userCar.model = Console.ReadLine();

            Console.WriteLine("Vehicle Year: ");
            userCar.year = int.Parse(Console.ReadLine());

            Console.WriteLine("Vehicle Color: ");
            userCar.color = Console.ReadLine();

            Console.WriteLine("Vehicle Engine Size: ");
            userCar.engineLiter = double.Parse(Console.ReadLine());

            recordList.Add(userCar);
        }

        foreach (var record in recordList) 
        {
            Console.WriteLine($"Vehicale Brand: {record.brand} \n Vehicle Model: {record.model} \n " +
                $"Vehicle Year: {record.year} \n Vehicle Engine Size: {record.engineLiter} \n");
        }
    }
}