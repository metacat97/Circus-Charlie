using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLoop : MonoBehaviour
{
    private float width;
    public float meter = 100f;

    // Start is called before the first frame update
    private void Awake()
    {
        BoxCollider2D objectCollider = GetComponent<BoxCollider2D>();
        width = objectCollider.size.x;
       
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
        //���� ��ġ�� �������� �������� width �̻� �̵������� ��ġ�� ���ġ
        //
        if (transform.position.x <= -width * 2f)
        {
            RepositionRight();
            //if (meter >= 100.0f)
            //{
            //    meter = 100.0f;
            //    //setActive true ���� ���� 
            //    //setActive false ����� �ڽ�
            //}
        }
        if (transform.position.x >= width * 2f)
        {
            RepositionLeft();
            //if (meter <= 0 )
            //{
            //    meter = 0;
            //}
        }
    }

    private void RepositionRight()
    {
        Vector2 offset = new Vector2((width * 4f), 0);
        transform.position = (Vector2)transform.position + offset;
        meter -= 10;
        if (meter <= 0.0f)
        {
            meter = 0.0f;
            //setActive true ���� ���� 
            //setActive false ����� �ڽ�
        }
        GFunc.Log(meter);
    }
    private void RepositionLeft()
    {
        Vector2 offset = new Vector2((width * 4f), 0);
        transform.position = (Vector2)transform.position - offset;
        meter += 10;
        if (meter >= 100f)
        {
            meter = 100f;
        }
        GFunc.Log(meter);
    }

}
