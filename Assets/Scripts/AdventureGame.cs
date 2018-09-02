using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	[SerializeField] Text storyTitleComponent;
	[SerializeField] Text storyTextComponent;
    [SerializeField] StoryScene currentState;

	// Use this for initialization
	void Start () {
        setComponents();
	}

    void setComponents() {
        storyTitleComponent.text = currentState.getStoryTitle();
        storyTextComponent.text = currentState.getStory();
    }

	// Update is called once per frame
	void Update () {
        var scenes = currentState.getLinkedScenes();
        int nbStates = scenes.Length;
        // There can only be up to 9 linked states (for the 1 to 9
        // digits of the keyboard). For the players, it does not 
        // make sense to use 0 as 10th.
        for (int i = 0; i < nbStates && i < 9; ++i) {
            if (
                // KeyCode.Alpha0 == 48
                Input.GetKeyDown((KeyCode) (48 + i + 1))
                // KeyCode.KeyPad0 == 256
                || Input.GetKeyDown((KeyCode) (256 + i + 1))
            ) {
                currentState = scenes[i];
                setComponents();
            }
        }
	}
}
