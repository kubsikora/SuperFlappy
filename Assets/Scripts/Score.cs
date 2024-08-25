using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;

    private int _score;

    private void Start()
    {
        _currentScoreText.text = _score.ToString();
    }

    private void Awake()
    {
        // Poprawiono: Poprawiono przypisanie instancji
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
    }
}
