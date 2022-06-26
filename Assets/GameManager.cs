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
        // 3,2,1 시간 보여주기.

        UpdateScoreText(0);

        //게임 매니져에서 코루틴 시작하기
    }
    private void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        // GameOverUI 보여주기

        // 블락 리젠 멈추가.
    }
}
