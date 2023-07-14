using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //public GameObject[] obstacles; // 장애물 오브젝트들
    public GameObject[] fixItems; // 고정되는 물체들
    private bool Goalstepped = false; // 플레이어 캐릭터가 밟았는가
    private ObjectLoop testplatform; //미터값 가져오기 위한 테스트 값
    public GameObject playerTest; //움직일 오브젝트 가져오기

    //컴포넌트가 활성화될 때마다 매번 실행되는 메서드
    //private void OnEnable()
    //{
    //    stepped = false;
    //    //발판을 리셋하는 처리 


    //    for (int i = 0; i < fixItems.Length; i++)
    //    {
    //        fixItems[i].SetActive(true);
    //    }


    //}

    private void Awake()
    {
        testplatform = GetComponent<ObjectLoop>();
    }
    void Update()
    {
        if (testplatform.meter <= 0)
        {
            testplatform.meter = 0;
            //for (int i = 0; i < fixItems.Length-1; i++) 
            //{ 
            //    fixItems[i].SetActive(false);
            //}
            fixItems[2].SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player"&& !Goalstepped)
        {
            //점수를 추가하고 밟힘 상태를 참으로 변경
            Goalstepped = true;
            //GameManager.instance.AddScore(1);
            //GameManager.instance

        }
    }
}
