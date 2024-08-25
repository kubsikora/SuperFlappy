using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menager : MonoBehaviour
{
    public static Menager instance;

    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private Button _restartButton;
    [SerializeField] private GameObject _startMenuCanvas;
    [SerializeField] private Button _startButton;

    private static bool _gameStarted = false;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void ResetStaticVariables()
    {
        _gameStarted = false;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
        _restartButton.onClick.AddListener(RestartGame);
        _startButton.onClick.AddListener(StartGame);

        if (_gameStarted)
        {
            _startMenuCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 0f;
            _startMenuCanvas.SetActive(true);
        }
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        _gameStarted = true;
        _startMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
