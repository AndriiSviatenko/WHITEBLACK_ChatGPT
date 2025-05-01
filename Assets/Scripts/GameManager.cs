using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    private void OnEnable()
    {
        EventBus.ClearEvents();
        Time.timeScale = 1f;

        EventBus.Subscribe(EventType.PlayerLost, OnPlayerLost);
        EventBus.Subscribe(EventType.PlayerWon, OnPlayerWon);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe(EventType.PlayerLost, OnPlayerLost);
        EventBus.Unsubscribe(EventType.PlayerWon, OnPlayerWon);
    }

    private void OnPlayerLost()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnPlayerWon()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
