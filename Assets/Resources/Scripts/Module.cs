using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Module {
    public abstract void use(Object node);
    public abstract string getName();
    public abstract int getLevel();
}
