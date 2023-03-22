using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;

    public void RestartGame()
    {
        TrackPoints.points = 0;
        GameObject.Find("Ship Spawner").GetComponent<ShipSpawner>().ResetRespawns();

        gameOverMenu.SetActive(false);
    }
}
