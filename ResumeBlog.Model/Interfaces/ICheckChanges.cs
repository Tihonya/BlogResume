namespace ResumeBlog.Model.Interfaces
{
    public interface ICheckChanges
    {
        bool IsDirty { get; set; }
    }
}