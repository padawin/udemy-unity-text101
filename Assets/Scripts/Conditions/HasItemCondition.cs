using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HasItemCondition")]
public class HasItemCondition : SceneStateCondition {
	[SerializeField] bool hasIt;
	[SerializeField] string item;

	override public bool test() {
		return FindObjectOfType<Player>().hasItem(item) == hasIt;
	}
}
