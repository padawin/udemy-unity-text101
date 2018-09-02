using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player")]
public class Player : ScriptableObject {
    List<string> inventory = new List<string>();

    public void addItem(string item) {
        inventory.Add(item);
    }

    public bool hasItem(string item) {
        return inventory.Contains(item);
    }
}
