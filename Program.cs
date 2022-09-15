namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/home/admina/Рабочий стол/testFolder");
                string trashPath = "/home/admina/.local/share/Trash/files/testFolder";
                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}