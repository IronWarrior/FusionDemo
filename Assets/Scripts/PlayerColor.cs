using UnityEngine;
using Fusion;

public class PlayerColor : NetworkBehaviour
{
    [Networked(OnChanged =nameof(IsRed_OnChanged), OnChangedTargets = OnChangedTargets.All)]
    public bool IsRed { get; set; }

    [SerializeField]
    private Renderer art;

    private static void IsRed_OnChanged(Changed<PlayerColor> changed)
    {
        changed.Behaviour.UpdateView();
    }

    private void UpdateView()
    {
        // art.material.color = IsRed ? Color.red : Color.green;
    }

    public override void Spawned()
    {
        UpdateView();
    }
}
