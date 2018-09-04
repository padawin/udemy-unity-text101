using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes this object creatable in Unity with right click -> create
[CreateAssetMenu(menuName = "State")]
public class SceneState : ScriptableObject {
	[TextArea(10, 14)] [SerializeField] string storyText;
	// Condition to set this state in the current scene
	[SerializeField] SceneStateCondition condition;
	[SerializeField] SceneAction[] actions;

	public bool isValid() {
		return condition == null || condition.test();
	}

	public string getStory() {
		return storyText;
	}

	public bool hasAction(int i) {
		return actions.Length > i;
	}

	public void executeAction(int i) {
		if (!hasAction(i)) {
			return;
		}

		actions[i].execute();
	}
}
