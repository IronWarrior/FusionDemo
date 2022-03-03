using Fusion;
using UnityEngine;

public partial class AuthorityColor : SimulationBehaviour, ISpawned
{
    public void Spawned()
    {
        foreach (var r in GetComponentsInChildren<Renderer>(true))
        {
            if (r.material.HasProperty("_Color"))
            {
                float a = r.material.color.a;

                r.material.color = !Object.HasStateAuthority ? new Color(0, 0.6f, 1, a) : new Color(1, 0.8f, 0.4f, a);
            }
        }
    }
}
