using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //public GameObject[] obstacles; // ��ֹ� ������Ʈ��
    public GameObject[] fixItems; // �����Ǵ� ��ü��
    private bool Goalstepped = false; // �÷��̾� ĳ���Ͱ� ��Ҵ°�
    private ObjectLoop testplatform; //���Ͱ� �������� ���� �׽�Ʈ ��
    public GameObject playerTest; //������ ������Ʈ ��������

    //������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    //private void OnEnable()
    //{
    //    stepped = false;
    //    //������ �����ϴ� ó�� 


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
            //������ �߰��ϰ� ���� ���¸� ������ ����
            Goalstepped = true;
            //GameManager.instance.AddScore(1);
            //GameManager.instance

        }
    }
}
