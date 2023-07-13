using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //public GameObject[] obstacles; // 장애물 오브젝트들
    public GameObject[] fixItems; // 고정되는 물체들
    private bool stepped = false; // 플레이어 캐릭터가 밟았는가

    //컴포넌트가 활성화될 때마다 매번 실행되는 메서드
    private void OnEnable()
    {
        stepped = false;
        //발판을 리셋하는 처리 

       
        for (int i = 0; i < fixItems.Length; i++)
        {
            fixItems[i].SetActive(true);
        }
      
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player"&& !stepped)
        {
            //점수를 추가하고 밟힘 상태를 참으로 변경
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}
