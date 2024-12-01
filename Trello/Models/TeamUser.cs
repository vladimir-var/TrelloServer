﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Trello.Models;

public partial class TeamUser
{
    public long Id { get; set; }

    public long? IdTeam { get; set; }

    public long? IdUser { get; set; }

    public string? Role { get; set; }
    [JsonIgnore]
    public virtual Team? IdTeamNavigation { get; set; }
    [JsonIgnore]
    public virtual UserInfo? IdUserNavigation { get; set; }
}
