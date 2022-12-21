namespace PrisonerSim
{
    public static class ConsoleUtility
    {
        public static void WritePercentage(float percent)
        {   
            int percentInt;

            if(percent < 1) {
                percentInt = 0;
            } else {
                percentInt = Convert.ToInt32(percent);
            }

            Console.CursorVisible = false; // Set cursor visibility to false

            Console.SetCursorPosition(0, 3); // Start cursor at start of line

            Console.Write(percentInt + "%"); // Write the percentage
        }
    }
}