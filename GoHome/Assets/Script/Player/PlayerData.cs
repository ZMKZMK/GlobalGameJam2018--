﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int blood = 0;
    public const int MAXBLOOD = 100;

    public PlayerData(int blood)
    {
        this.blood = blood;
    }
}
