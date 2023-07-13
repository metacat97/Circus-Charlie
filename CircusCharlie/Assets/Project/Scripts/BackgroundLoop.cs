using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    //����� ���� ����
    private float width;
    // Start is called before the first frame update

    private void Awake()
    {
        //���� ���� ����
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    

    // Update is called once per frame
    private void Update()
    {
        //���� ��ġ�� �������� �������� width �̻� �̵����� �� ��ġ�� ���ġ
        
        if (transform.position.x <= -width *2f)
        {
            RepositionRight();
        }
        else if (transform.position.x >= width *2f)
        {
            RepositionLeft();
        }
    }

    private void RepositionRight()
    {
        Vector2 offset = new Vector2((width * 4f), 0);
        transform.position = (Vector2) transform.position + offset;
    }
    private void RepositionLeft()
    {
        Vector2 offset = new Vector2((width * 4f), 0);
        transform.position = (Vector2)transform.position - offset;
    }

}