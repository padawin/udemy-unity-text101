using UnityEngine;

[CreateAssetMenu(menuName = "GetItemAction")]
public class GetItemAction : SceneAction {
	[SerializeField] public Player player;
	[SerializeField] string item;

	override public void execute() {
		player.addItem(item);
	}
}
