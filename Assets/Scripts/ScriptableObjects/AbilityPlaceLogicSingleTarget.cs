using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Place Logic/Single Target")]
public class AbilityPlaceLogicSingleTarget : AbilityPlaceLogic
{
    [SerializeField] private float _maxDistance;
    public override List<Unit> TryGetTargets(Vector2 screenPoint)
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1));

        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, _maxDistance))
        {
            if (hit.transform.GetComponent<Unit>())
            {
                return new List<Unit>() { hit.transform.GetComponent<Unit>() };
            }
        }

        return null;
    }
}
