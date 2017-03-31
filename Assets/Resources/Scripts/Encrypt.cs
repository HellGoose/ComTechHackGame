using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encrypt : Module {
    private int level;
    private string name;

    public Encrypt(int level)
    {
        this.level = level;
        name = "encrypt()";
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
