using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proxy : Module
{
    private int level;
    private string name;

    public Proxy(int level)
    {
        this.level = level;
        name = "Proxy()";
    }

    public override void use(UnityEngine.Object node)
    {
        throw new NotImplementedException();
    }

    public override int getLevel()
    {
        return level;
    }

    public override string getName()
    {
        return name;
    }
}
