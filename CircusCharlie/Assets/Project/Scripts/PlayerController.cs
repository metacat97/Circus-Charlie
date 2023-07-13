using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //사망시 재생할 오디오 클립
    //public AudioClip deathClip; //사망시 재생할 오디오 클립 넣어줄 것이기에 디폴트 안함

    //점프 힘
    public float jumpForce = 500f;
    //점프 횟수 
    private int jumpCount = 0;
    //바닥에 닿았는지
    //private bool isGrounded;
    //오른쪽으로 가고 있는지
    //private bool isGoing = false;
    // 사망상태
    private bool isDead = false;

    //사용할 리지드 바디 컴포넌트
    private Rigidbody2D playerRigidbody;
    //사용할 애니메이터 컴포넌트
    //private Animator animator;
    //사용할 오디오 소스 컴포넌트
    //private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //초기화
        
        //게임 오브젝트로보투 사용할 컴포넌트들을 가져와 변수에 할당
        playerRigidbody = GetComponent<Rigidbody2D>();
        GFunc.Assert(playerRigidbody != null);
        
        //animator = GetComponent<Animator>();
        //GFunc.Assert(animator != null);
        //playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //사용자 입력을 감지하고 점프하는 처리
        if (isDead)
        {
            //사망 시 처리를 더 이상 진행하지 않고 종료
            return;
        }
        // 스페이스 키를 눌렀으며 && 최대 점프 횟수 (1)에 도달하지 않았다면
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount <1)
        {
            //점프 횟수 증가
            jumpCount++;
            //점프 직전에 속도를 순간적으로 제로(0,0)로 변경
            playerRigidbody.velocity = Vector2.zero;
            //리지드 바디에 위쪽으로 힘주기
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            //오디오 소스 재생
            //playerAudio.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space) && playerRigidbody.velocity.y>0)
        {
            // 마우스 왼쪽 버튼에서 손을 떼는 순간 && 속도의 y값이 양수라면(위로 상승 중)
            // 현재 속도를 절반으로 변경
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;
        }
        //애니메이터의 Grounded 파라미터를 isGrounded 값으로 갱신
       // animator.SetBool("Grounded", isGrounded);
        //애니메이터의 GoingH파라미터를 isGrounded 값으로 갱신
        //animator.SetBool("Going", isGoing);

        
    }

    private void Die()
    {
        //사망처리
        //애니메이터의 Die트리터 파라미터를 셋
        //animator.SetTrigger("Die");
        //오디오 소스에할당된 오디오 클립을 deathClip로 변경
        //playerAudio.clip = deatClip;
        //속도를 제로(0, 0)로 변경
        playerRigidbody.velocity = Vector2.zero;
        // 사망 상태를 true로 변경
        isDead = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 트리거 콜라이더를 가진 장애물과의 충돌을 감지
        if(other.tag == "Dead" && !isDead)
        {
            //충돌한 상대방의 태그가 Dead이며 아직 사망하지 않았다면 Die()실행
            Die();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //바닥에 닿았음을 감지하는 처리
        //isGorunded를 true로 변경하고, 누적 점프 횟수를 0으로 리셋
        //isGrounded = true;
        //isGoing = true;
        jumpCount = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //바닥에서 벗어났음을 감지하는 처리.      
        //isGrounded = false;
        //isGoing = false;
    }


}
