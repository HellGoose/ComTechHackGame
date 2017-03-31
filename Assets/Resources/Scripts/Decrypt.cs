using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decrypt : Module {
    private int level;
    private string name;

    public Decrypt(int level)
    {
        this.level = level;
        name = "decrypt()";
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
