using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes this object creatable in Unity with right click -> create
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    /*
     * create SceneState and SceneStateCondition classes (a scene state has a condition)
     * Rename into StoryScene (A scene has multiple states and a single active)
     * When initialising scene, go through its states and find the first for which the condition is valid and set it as active
     * 
     * 
     */
    [SerializeField] string storyTitle;
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] linkedStates;

    public string getStoryTitle() {
        return storyTitle;
    }

    public string getStory() {
        return storyText;
    }

    public State[] getLinkedStates() {
        return linkedStates;
    }
}
