using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerColor>(out var pc))
        {
            if (pc.Object.HasStateAuthority)
            {
                pc.IsRed = true;
            }
        }
    }
}
