using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //��Ŭ�� �Ҵ��� ���� ���� 
    public static GameManager instance;


    public bool isGameover = false;//���� ��������
    
    //public Text scoreText; //���� ��� UI�ؽ�Ʈ
    public TMP_Text scoreText;
    public GameObject gameoverUI; // ���ӿ��� �� Ȱ��ȭ�� UI���� ������Ʈ
    //public bool SpeedBoolCheck; //���ǵ� üũ  
    private int score = 0; // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    void Awake()
    {
        //�̱� �� ���� instance �� ��� �ִ���?
        if (instance == null)
        {
            //instance�� ��� �ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            //instance�� �̹� �ٸ� GameManaver ������Ʈ�� �Ҵ� �Ǿ� �ִ� ���

            //���� �� �� �̻��� GameManager ������Ʈ�� �����Ѵٴ� �ǹ�
            //�̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }

    }

    void Update()
    {
        //���� ���� ���¿��� ����� �� �� �ְ� ó��    
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
