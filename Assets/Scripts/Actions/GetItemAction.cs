﻿using UnityEngine;

[CreateAssetMenu(menuName = "GetItemAction")]
public class GetItemAction : SceneAction {
	[SerializeField] string item;

    override public void execute() {
        player.addItem(item);
   }
}
