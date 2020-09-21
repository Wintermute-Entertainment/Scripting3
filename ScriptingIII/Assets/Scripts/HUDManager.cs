using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class HUDManager : MonoBehaviour
{
    //THIS IS SINGLETON
    public static HUDManager instance;

    public static HUDManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<HUDManager>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<HUDManager>();
                    singleton.name = "(Singleton) HUDManager";
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }

    //SINGLETON ENDS HERE
    

    public TextMeshProUGUI instructions;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timeElapsedText;

    public Material wall_Mat;
    public Material wall2_Mat;
    public Material wall3_Mat;
    public Material wall4_Mat;

    public GameObject wall;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    public int gameTime;
    private void Start()
    {
        wall_Mat.DOColor(Color.blue, 4f);
        wall2_Mat.DOColor(Color.yellow, 4f);
        wall3_Mat.DOColor(Color.red, 4f);
        wall4_Mat.DOColor(Color.green, 4f);

        instructions.transform.DOPunchScale(Vector3.one * 3, 3, 3);
        
    }
    public void DestoryInstructions()
    {
        Destroy(instructions.gameObject);
        return;
    }
    public void DestroyScoreText()
    {
        Destroy(scoreText.gameObject);
        return;
    }
    public void DestroyTimeElapsedText()
    {
        Destroy(timeElapsedText.gameObject);
        return;
    }

}
