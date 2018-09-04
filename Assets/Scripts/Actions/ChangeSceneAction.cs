using UnityEngine;

[CreateAssetMenu(menuName = "ChangeSceneAction")]
public class ChangeSceneAction : SceneAction {
	[SerializeField] SceneManager sceneManager;
	[SerializeField] StoryScene newScene;

	override public void execute() {
		sceneManager.setScene(newScene);
	}
}
