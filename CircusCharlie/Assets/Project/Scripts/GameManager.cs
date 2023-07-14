using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //싱클턴 할당할 전역 변수 
    public static GameManager instance;


    public bool isGameover = false;//게임 오버상태
    
    //public Text scoreText; //점수 출력 UI텍스트
    public TMP_Text scoreText;
    public GameObject gameoverUI; // 게임오버 시 활성화할 UI게임 오브젝트
    //public bool SpeedBoolCheck; //스피드 체크  
    private int score = 0; // 게임 점수

    // 게임 시작과 동시에 싱글턴을 구성
    void Awake()
    {
        //싱글 턴 변수 instance 가 비어 있는지?
        if (instance == null)
        {
            //instance가 비어 있다면(null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            //instance에 이미 다른 GameManaver 오브젝트가 할당 되어 있는 경우

            //씬에 두 개 이상의 GameManager 오브젝트가 존재한다는 의미
            //싱글턴 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }

    }

    void Update()
    {
        //게임 오버 상태에서 재시작 할 수 있게 처리    
        if (isGameover && Input.GetKeyDown(KeyCode.Space ))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        scoreText.text = string.Format("Score : {0}", score);
    }
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
   
    //public void SetSpeed(bool boolchk)
    //{
    //    SpeedBoolCheck = boolchk;
    //}
}
