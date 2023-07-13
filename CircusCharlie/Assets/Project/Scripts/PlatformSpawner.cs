using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;//생성할 발판의 원본프리팹
    public int count = 10; //생성할 발판 수

   
    public float yPos = 1.0f;
    private float xPos = 5.0f;

    private GameObject[] platforms; //미리 생성할 발판들
    private int currentIndex = 0; //사용할 현재 순번의 발판

    //초반에 생성한 발판을 화면 밖에 숨겨둘 위치
    private Vector2 poolPosition = new Vector2(0, -25);
    //private float lastSpawnTime; //마지막 배치 시점




    // Start is called before the first frame update
    void Start()
    {
        //변수 초기화 사용할발판 미리 생성    
        platforms = new GameObject[count];

        //count만큼 루프하면서 발판 생성
        for(int i = 0; i < count; i ++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
        }

        lastSpawnTime = 0f;
       
    }

    // Update is called once per frame
    void Update()
    {
        //순서를 돌아가며 주기적으로 발판을 패치 
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


        // 현재 순번의 발판을 화면 오른쪽에 재배치
        platforms[currentIndex].transform.position = new Vector2(xPos, 1.0f);
        //순번 넘기기
        currentIndex++;

        //마지막 순번에 도달했다면 순번들 리셋
        if (currentIndex >= count)
        {
            currentIndex = 0;
        }
    }
}
