using UnityEngine;

public class LightZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EventBus.RaiseEvent(EventType.PlayerLost);
        }
    }
}
