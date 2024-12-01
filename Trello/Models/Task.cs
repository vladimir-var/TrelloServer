﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Trello.Models;

public partial class Task
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public bool? Iscompleted { get; set; }

    public long? IdCard { get; set; }
    [JsonIgnore]
    public virtual Card? IdCardNavigation { get; set; }
}
