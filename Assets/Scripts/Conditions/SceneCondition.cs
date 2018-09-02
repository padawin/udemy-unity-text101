using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneStateCondition : ScriptableObject {
    abstract public bool test();
}
