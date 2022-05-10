using System.IO;
using System.Text;
using System.Text.Encodings;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);
    }
    public class FileManager : IFileManager
    {
        private readonly Encoding _encoding = Encoding.UTF8;
        
        public bool IsExist(string filePath)
        {
            return File.Exists(filePath);
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _encoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _encoding);
        }
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }

    }
}