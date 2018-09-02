using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneAction : ScriptableObject {
    [SerializeField] public Player player;

    abstract public void execute();
} 
