namespace Siotrix
{
    public interface IPermission
    {
        string Name { get; }
        ulong Bit { get; }
    }
}
