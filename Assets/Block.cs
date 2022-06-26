using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameManager gameManager;
    public BlockSpawner spawner;
    public float speed = 5;
    void Update()
    {
        float moveSpeed = dir == Direction.Right ? speed : -speed;
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }

    public Direction dir;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (enabled == false)
            return;

        enabled = false;

        spawner.waitSpawn = false;
        gameManager.AddScore(100);
        //FindObjectOfType<BlockSpawner>().wait = false;



        // (0.00, -1.00) 성공 : 점수 증가.
        // (-1.00, 0.00) 실패 : 게임 종료, 캐릭터 죽는 애니메이션 시작.
        //print(collision.contacts[0].normal);
        //var normal = collision.contacts[0].normal;
        //if(Mathf.Abs(normal.x) > 0.1)
        //{
        //    //collision.transform.GetComponent<Player>().Die();
        //}
    }
}
