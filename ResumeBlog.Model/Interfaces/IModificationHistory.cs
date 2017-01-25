using System;

namespace ResumeBlog.Model.Interfaces
{
    public interface IModificationHistory : ICheckChanges
    {
        DateTime DateModified { get; set; }
        DateTime DateCreated { get; set; }
    }
}
