using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private Obstacl _enemy;
    [SerializeField] TMP_Text _scoreText;
    private int _score = 10;

    private void SetText()
    {
        _scoreText.text = _score.ToString();
    }
    private void Start()
    {
        _enemy = GetComponent<Obstacl>();
    }

    private void Update()
    {
        SetText();
    }
}
