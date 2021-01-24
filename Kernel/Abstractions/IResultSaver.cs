namespace WSP.Abstractions
{
    public interface IResultSaver<TResult>
    {
        void SaveResult(TResult result);
    }
}
