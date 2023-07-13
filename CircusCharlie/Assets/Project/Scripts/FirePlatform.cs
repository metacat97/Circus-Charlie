using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlatform : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject[] obstacles;
    
    
    private void OnEnable()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 3)==0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
