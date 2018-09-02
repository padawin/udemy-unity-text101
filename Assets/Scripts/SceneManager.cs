using UnityEngine;

[CreateAssetMenu(menuName = "SceneManager")]
public class SceneManager : ScriptableObject {
    StoryScene currentScene;

    public void setScene(StoryScene scene) {
        currentScene = scene;
    }

    public StoryScene getScene() {
        return currentScene;
    }
}
