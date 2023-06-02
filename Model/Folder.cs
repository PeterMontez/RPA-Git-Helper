using System;
using System.Collections.Generic;

namespace GitManager.Model;

public partial class Folder
{
    public int Id { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<Repository> Repositories { get; set; } = new List<Repository>();
}
