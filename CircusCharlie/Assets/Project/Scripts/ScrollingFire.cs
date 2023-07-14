using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingFire : MonoBehaviour
{
    //GameObject obj;
    
    public float speed = 10f;
    //private bool testCheck = default;

    // Start is called before the first frame update
    void Start()
    {
        //obj = GameObject.Find("FirePlatform");
        //testCheck = obj.GetComponent<ScrollingObject>().LDCheck;

    }   

    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        //if (testCheck == true) 
        //{
        //    GFunc.Log(testCheck);
        //    transform.Translate(Vector3.left * speed/2 * Time.deltaTime);
        //}
        //else if(testCheck == false) 
        //{
        //    GFunc.Log(testCheck);
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}
    }
}
