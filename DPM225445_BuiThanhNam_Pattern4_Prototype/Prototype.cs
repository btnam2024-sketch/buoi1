﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Prototype
{
    string id;

    // Constructor

    public Prototype(string id)
    {
        this.id = id;
    }

    // Nhập Id

    public string Id
    {
        get { return id; }
    }

    public abstract Prototype Clone();
}
