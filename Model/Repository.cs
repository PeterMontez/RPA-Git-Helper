using System;
using System.Collections.Generic;

namespace GitManager.Model;

public partial class Repository
{
    public int Id { get; set; }

    public string? Path { get; set; }

    public int IdMainFolder { get; set; }

    public virtual Folder IdMainFolderNavigation { get; set; } = null!;
}
