﻿using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnimMethod //Filip
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public List<string> Parameters;
    [SerializeField]
    public string Code;

    public AnimMethod(string Name, string Code)
    {
        this.Name = Name;
        this.Code = Code;
    }
}
