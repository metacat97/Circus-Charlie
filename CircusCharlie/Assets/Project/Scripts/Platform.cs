using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //public GameObject[] obstacles; // ��ֹ� ������Ʈ��
    public GameObject[] fixItems; // �����Ǵ� ��ü��
    private bool stepped = false; // �÷��̾� ĳ���Ͱ� ��Ҵ°�

    //������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        stepped = false;
        //������ �����ϴ� ó�� 

       
        for (int i = 0; i < fixItems.Length; i++)
        {
            fixItems[i].SetActive(true);
        }
      
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player"&& !stepped)
        {
            //������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}
