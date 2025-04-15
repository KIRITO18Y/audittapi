﻿using Auditt.Application.Domain.Primitives;

namespace Auditt.Application.Domain.Entities;
public class Setting : AggregateRoot
{
    public Setting(int id, string name, string description, string value) : base(id)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Value { get; private set; }
    public List<SettingUser> SettingUsers { get; private set; }

    public void Update(string name, string description, string value)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    public void Update(string description, string value)
    {
        Value = value;
        Description = description;
    }
    public void Update(string value)
    {
        Value = value;
    }

}
