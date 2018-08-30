using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes this object creatable in Unity with right click -> create
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    [TextArea(10, 14)] [SerializeField] string storyText;

    public string getStory() {
        return storyText;
    }
}
