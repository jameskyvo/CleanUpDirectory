using static FileManager;

if (args.Length == 3)
{
    // Command Line Arguments
    string dirToClean = args[0];
    int daysBeforeClean = int.Parse(args[1]);
    bool isRecursive = bool.Parse(args[2].ToLower());
    SearchOption searchOption;

    // Sets the search option according to the value of isRecursive
    searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

    FileManager.RemoveInactiveFiles(dirToClean, daysBeforeClean, searchOption);
}
else
{
    throw new Exception("Invalid number of arguments provided. Usage: Program <dirToClean> <daysBeforeClean> <isRecursive>");
}
