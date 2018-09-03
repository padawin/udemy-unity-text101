using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes this object creatable in Unity with right click -> create
[CreateAssetMenu(menuName = "StoryScene")]
public class StoryScene : ScriptableObject {
    [SerializeField] string storyTitle;
    [SerializeField] SceneState[] states;
    int currentState = 0;

    public string getStoryTitle() {
        return storyTitle;
    }

    public string getStory() {
        return states[currentState].getStory();
    }

    public bool hasAction(int i) {
        return states[currentState].hasAction(i);
    }

    public void executeAction(int i) {
        states[currentState].executeAction(i);
        setState();
    }

    public void setState() {
        // Find new state to set as current one
        int nbStates = states.Length;
        for (int s = 0; s < nbStates; ++s) {
            if (states[s].isValid()) {
                currentState = s;
                break;
            }
        }
    }
}
