namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/home/admina" /* Или С:\\ для Windows */ );
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/home/admina/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

                Console.WriteLine($"Название каталога: {dirInfo.Name}");
                Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                Console.WriteLine($"Корневой каталог: {dirInfo.Root}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/home/admina/newDirectory");
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}