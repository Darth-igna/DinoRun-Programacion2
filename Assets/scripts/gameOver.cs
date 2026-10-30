using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public static gameOver instancia;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActivarGameOver()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}