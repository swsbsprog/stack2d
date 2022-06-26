using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum StateType
{
    WaitStart,
    Playing,
    End
}

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public StateType state = StateType.WaitStart;
    public void AddScore(int addScore)
    {
        score += addScore;
        UpdateScoreText(score);
    }
    private void Start()
    {
        // 3,2,1 �ð� �����ֱ�.

        UpdateScoreText(0);

        //���� �Ŵ������� �ڷ�ƾ �����ϱ�
    }
    private void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        // GameOverUI �����ֱ�

        // ��� ���� ���߰�.
    }
}
