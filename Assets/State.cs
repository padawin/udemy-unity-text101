using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes this object creatable in Unity with right click -> create
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    [SerializeField] string storyTitle;
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] linkedStates;

    public string getStoryTitle() {
        return storyTitle;
    }

    public string getStory() {
        return storyText;
    }

    public State getStateAt(int index)
    {
        if (index < 1 || index > linkedStates.Length) {
            return null;
        }
        return linkedStates[index - 1];
    }

    public State[] getLinkedStates() {
        return linkedStates;
    }
}
