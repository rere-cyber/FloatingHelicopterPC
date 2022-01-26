using UnityEngine;


public class Collisionable : MonoBehaviour
{
    public GameObject _gameOverCanvas;

    private void Awake()
    {
        _gameOverCanvas.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
