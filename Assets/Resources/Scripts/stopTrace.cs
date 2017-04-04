using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopTrace : Module
{
    private int level;
    private string name;

    public stopTrace(int level)
    {
        this.level = level;
        name = "stopTrace()";
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
