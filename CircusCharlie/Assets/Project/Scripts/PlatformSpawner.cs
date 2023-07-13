using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;//������ ������ ����������
    public int count = 10; //������ ���� ��

   
    public float yPos = 1.0f;
    private float xPos = 5.0f;

    private GameObject[] platforms; //�̸� ������ ���ǵ�
    private int currentIndex = 0; //����� ���� ������ ����

    //�ʹݿ� ������ ������ ȭ�� �ۿ� ���ܵ� ��ġ
    private Vector2 poolPosition = new Vector2(0, -25);
    //private float lastSpawnTime; //������ ��ġ ����




    // Start is called before the first frame update
    void Start()
    {
        //���� �ʱ�ȭ ����ҹ��� �̸� ����    
        platforms = new GameObject[count];

        //count��ŭ �����ϸ鼭 ���� ����
        for(int i = 0; i < count; i ++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
        }

        lastSpawnTime = 0f;
       
    }

    // Update is called once per frame
    void Update()
    {
        //������ ���ư��� �ֱ������� ������ ��ġ 
        //if (GameManager.instance.isGameover)
        //{
        //    return;
        //}

        //if (Time.time >= lastSpawnTime + timeBetSpawn)
        //{
        //    lastSpawnTime = Time.time;

        //    timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);

            
        //}
        platforms[currentIndex].SetActive(false);
        platforms[currentIndex].SetActive(true);


        // ���� ������ ������ ȭ�� �����ʿ� ���ġ
        platforms[currentIndex].transform.position = new Vector2(xPos, 1.0f);
        //���� �ѱ��
        currentIndex++;

        //������ ������ �����ߴٸ� ������ ����
        if (currentIndex >= count)
        {
            currentIndex = 0;
        }
    }
}
