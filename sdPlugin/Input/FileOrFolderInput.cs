namespace sdPlugin.Input
{
    public class FileOrFolderInput : BaseInput
    {
        public string Path { get; set; }
        public bool IsFileInputVisible { get; set; }
        public bool IsFolderInputVisible { get; set; }

        public FileOrFolderInput(string name, bool isFileInputVisible, bool isFolderInputVisible, string path = "") : base(name)
        {
            if (!isFileInputVisible && !isFolderInputVisible)
                isFileInputVisible = true;

            Path = path;
            IsFileInputVisible = isFileInputVisible;
            IsFolderInputVisible = isFolderInputVisible;
        }
    }
}
