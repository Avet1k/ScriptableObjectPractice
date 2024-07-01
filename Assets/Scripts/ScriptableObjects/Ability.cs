using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/New Ability")]
public class Ability : ScriptableObject
{
    [SerializeField] private AbilityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _abilityAction;
    
    public void ApplyAction(List<Unit> targets)
    {
        foreach (var ability in _abilityAction)
        {
            foreach (var target in targets)
            {
                ability.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _placeLogic.TryGetTargets(screenPoint);
    }
}
