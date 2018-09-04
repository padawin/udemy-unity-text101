using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	[SerializeField] Text sceneTitleComponent;
	[SerializeField] Text sceneTextComponent;
	[SerializeField] StoryScene initialScene;
	[SerializeField] SceneManager sceneManager;

	// Use this for initialization
	void Start () {
		sceneManager.setScene(initialScene);
		setComponents();
	}

	void setComponents() {
		sceneTitleComponent.text = sceneManager.getScene().getStoryTitle();
		sceneTextComponent.text = sceneManager.getScene().getStory();
		// sceneChoicesComponent.text = sceneManager.getScene().getChoices();
	}

	// Update is called once per frame
	void Update () {
		// There can only be up to 9 linked states (for the 1 to 9
		// digits of the keyboard). For the players, it does not
		// make sense to use 0 as 10th.
		for (int i = 0; i < 9; ++i) {
			if (
				// KeyCode.Alpha0 == 48
				Input.GetKeyDown((KeyCode) (48 + i + 1))
				// KeyCode.KeyPad0 == 256
				|| Input.GetKeyDown((KeyCode) (256 + i + 1))
			) {
				if (sceneManager.getScene().hasAction(i)) {
					sceneManager.getScene().executeAction(i);
					setComponents();
					break;
				}
			}
		}
	}
}
