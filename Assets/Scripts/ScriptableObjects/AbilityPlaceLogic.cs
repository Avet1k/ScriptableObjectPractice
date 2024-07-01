using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityPlaceLogic : ScriptableObject
{
    public abstract List<Unit> TryGetTargets(Vector2 screenPoint);
}
