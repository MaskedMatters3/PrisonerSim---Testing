namespace PrisonerSim
{
    public static class ConsoleUtility
    {
        public static void WritePercentage(float percent)
        {   
            Console.CursorVisible = false; // Set cursor visibility to false

            Console.SetCursorPosition(0, 3); // Start cursor at start of line

            Console.Write(percent + "%"); // Write the percentage
        }
    }
}