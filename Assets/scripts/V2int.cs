﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2int  {

    private int xIP, yIP;

    public V2int()
    {
        x = 0;
        y = 0;
    }

    public V2int(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int x
    {
        get
        {
            return xIP;
        }
        set
        {
            xIP = value;
        }
    }

    public int y
    {
        get
        {
            return yIP;
        }
        set
        {
            yIP = value;
        }
    }
}
