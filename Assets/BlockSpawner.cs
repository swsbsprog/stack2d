using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Right, Left }
public class BlockSpawner : MonoBehaviour
{
    public Block block;
    public bool waitSpawn = true;
    public int level = 0;
    public float initStartY = -3;
    public float initStartX = 5;
    public float blockHeight = 1f;
    public Direction moveDirection = Direction.Left;

    IEnumerator Start()
    {
        block.gameObject.SetActive(false);

        while (true)
        {
            print("�� ��ȯ");

            var newBlock = Instantiate(block);
            newBlock.gameObject.SetActive(true);
            float x = moveDirection == Direction.Right ? -initStartX : initStartX;
            float y = initStartY + level * blockHeight;
            newBlock.transform.position = new Vector2(x, y);
            newBlock.dir = moveDirection;
            waitSpawn = true;
            //yield return new WaitWhile( () => wait); // true�� ���� ���
            //yield return new WaitUntil(() => wait); // true�� �ɶ����� ���
            while (waitSpawn)
                yield return null;

            print("�� �̵� �Ϸ�");
            level = level + 1;
            moveDirection = moveDirection == Direction.Right ? Direction.Left : Direction.Right;  
        }
    }
}
