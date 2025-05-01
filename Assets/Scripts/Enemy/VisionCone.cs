using UnityEngine;

public class VisionCone : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private float radius;

    public void CheckForPlayer()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, playerLayer);

        if (hit != null)
        {
            EventBus.RaiseEvent(EventType.PlayerLost);
        }
    }

    private void OnDrawGizmos() => 
        Gizmos.DrawWireSphere(transform.position, radius);
}
