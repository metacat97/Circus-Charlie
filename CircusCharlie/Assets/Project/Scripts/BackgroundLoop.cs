using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    //배경의 가로 길이
    private float width;
    // Start is called before the first frame update

    private void Awake()
    {
        //가로 길이 측정
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    

    // Update is called once per frame
    private void Update()
    {
        //현재 위치가 원점에서 왼쪽으로 width 이상 이동했을 떄 위치를 재배치
        if (transform.position.x <= -width *2f)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2((width * 4f), 0);
        transform.position = (Vector2) transform.position + offset;
    }
}
