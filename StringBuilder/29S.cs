namespace en
{
    class Program
    {
        enum Days2
        {
            None = 1,
            Sunday = 2,
            Monday = 3,
            Tuesday = 4,
            Wednesday = 5,
            Thursday = 6,
            Friday = 7,
            Saturday = 8
        }



        static void Main(string[] args)
        {
            Days2 meetingDays = Days2.Tuesday | Days2.Thursday;

            // Initialize with two flags using bitwise OR.
            meetingDays = Days2.Tuesday | Days2.Thursday;

            // Set an additional flag using bitwise OR.
            meetingDays = meetingDays | Days2.Friday;


            Console.WriteLine("Meeting days are {0}", meetingDays);
            // Expected Output: Meeting days are Tuesday, Thursday, Friday
            // Actual Output: Meeting days are  Friday**

            // Remove a flag using bitwise XOR.
            meetingDays = meetingDays ^ Days2.Tuesday;
            Console.WriteLine("Meeting days are {0}", meetingDays);

            // Expected Output: Meeting days are Thursday, Friday
            // Actaul Output: Meeting days are Monday**

            Console.ReadLine();

        }
    }
}