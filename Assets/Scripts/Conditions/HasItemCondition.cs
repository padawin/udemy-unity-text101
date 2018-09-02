using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HasItemCondition")]
public class HasItemCondition : SceneStateCondition {
    [SerializeField] public Player player;
    [SerializeField] bool hasIt;
    [SerializeField] string item;

    override public bool test() {
        return player.hasItem(item) == hasIt;
    }
}
