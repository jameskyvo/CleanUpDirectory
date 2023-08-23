public class FileManager
{
    public static void RemoveInactiveFiles(string dirToClean, int daysBeforeClean, SearchOption searchOption)
    {
        string allFileExtensions = "*.*";
        DirectoryInfo directoryInfo = new DirectoryInfo(dirToClean);
        List<FileInfo> files = directoryInfo.GetFiles(allFileExtensions, searchOption).ToList();

        foreach (FileInfo file in files)
        {
            if (DateTime.Now - file.LastWriteTime >= TimeSpan.FromDays(daysBeforeClean))
            {
                try
                {
                    file.Delete();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"There was an error deleting {file.Name} Exception: {ex.Message}");
                }
            }
        }
    }
}