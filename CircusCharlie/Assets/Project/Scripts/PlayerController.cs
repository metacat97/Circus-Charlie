using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //����� ����� ����� Ŭ��
    //public AudioClip deathClip; //����� ����� ����� Ŭ�� �־��� ���̱⿡ ����Ʈ ����

    //���� ��
    public float jumpForce = 500f;
    //���� Ƚ�� 
    private int jumpCount = 0;
    //�ٴڿ� ��Ҵ���
    //private bool isGrounded;
    //���������� ���� �ִ���
    //private bool isGoing = false;
    // �������
    private bool isDead = false;

    //����� ������ �ٵ� ������Ʈ
    private Rigidbody2D playerRigidbody;
    //����� �ִϸ����� ������Ʈ
    //private Animator animator;
    //����� ����� �ҽ� ������Ʈ
    //private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //�ʱ�ȭ
        
        //���� ������Ʈ�κ��� ����� ������Ʈ���� ������ ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        GFunc.Assert(playerRigidbody != null);
        
        //animator = GetComponent<Animator>();
        //GFunc.Assert(animator != null);
        //playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //����� �Է��� �����ϰ� �����ϴ� ó��
        if (isDead)
        {
            //��� �� ó���� �� �̻� �������� �ʰ� ����
            return;
        }
        // �����̽� Ű�� �������� && �ִ� ���� Ƚ�� (1)�� �������� �ʾҴٸ�
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount <1)
        {
            //���� Ƚ�� ����
            jumpCount++;
            //���� ������ �ӵ��� ���������� ����(0,0)�� ����
            playerRigidbody.velocity = Vector2.zero;
            //������ �ٵ� �������� ���ֱ�
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            //����� �ҽ� ���
            //playerAudio.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space) && playerRigidbody.velocity.y>0)
        {
            // ���콺 ���� ��ư���� ���� ���� ���� && �ӵ��� y���� ������(���� ��� ��)
            // ���� �ӵ��� �������� ����
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;
        }
        //�ִϸ������� Grounded �Ķ���͸� isGrounded ������ ����
       // animator.SetBool("Grounded", isGrounded);
        //�ִϸ������� GoingH�Ķ���͸� isGrounded ������ ����
        //animator.SetBool("Going", isGoing);

        
    }

    private void Die()
    {
        //���ó��
        //�ִϸ������� DieƮ���� �Ķ���͸� ��
        //animator.SetTrigger("Die");
        //����� �ҽ����Ҵ�� ����� Ŭ���� deathClip�� ����
        //playerAudio.clip = deatClip;
        //�ӵ��� ����(0, 0)�� ����
        playerRigidbody.velocity = Vector2.zero;
        // ��� ���¸� true�� ����
        isDead = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����
        if(other.tag == "Dead" && !isDead)
        {
            //�浹�� ������ �±װ� Dead�̸� ���� ������� �ʾҴٸ� Die()����
            Die();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�ٴڿ� ������� �����ϴ� ó��
        //isGorunded�� true�� �����ϰ�, ���� ���� Ƚ���� 0���� ����
        //isGrounded = true;
        //isGoing = true;
        jumpCount = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //�ٴڿ��� ������� �����ϴ� ó��.      
        //isGrounded = false;
        //isGoing = false;
    }


}
