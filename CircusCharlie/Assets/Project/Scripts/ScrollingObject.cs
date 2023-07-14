using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    //이동속도
    public float speed;
    //public bool LDCheck = false; //왼쪽을 누르는지 체크하는 불 값
    
    //public float maxSpeed;
    //Rigidbody2D rigid;
    //private BoxCollider2D BackGround = default;

    void Awake()
    {
        //BackGround = GetComponent<BoxCollider2D>();
        //rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        float xSpeed = xInput * speed * Time.deltaTime;
        float zSpeed = zInput * speed * Time.deltaTime;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        transform.Translate(Vector3.right * -xSpeed);
        
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    //LDCheck = true;    
        //    GameManager.instance.SetSpeed(true);
        //}
        
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    //LDCheck = false;
        //    GameManager.instance.SetSpeed(false);
        //}


        //rigid.velocity = newVelocity;

        //float h = Input.GetAxisRaw("Horizontal");

        //rigid.AddForce(Vector2.left * h, ForceMode2D.Impulse);

        //if (rigid.velocity.x > maxSpeed) // Right Max Speed
        //{
        //    rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        //}
        //else if (rigid.velocity.x < maxSpeed*(-1))
        //{
        //    rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
        //}
        //else if (Input.GetKeyDown(KeyCode.W)) 
        //{
        //    maxSpeed += 1;
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    maxSpeed -= 1;
        //}
        // else { maxSpeed = 0; }


        //transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
