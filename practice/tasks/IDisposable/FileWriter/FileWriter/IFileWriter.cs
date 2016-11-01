namespace Convestudo.Unmanaged
{
    public interface IFileWriter : System.IDisposable
    {
        void Write(string str);
        void WriteLine(string str);
    }
}