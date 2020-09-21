using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;
using TMPro;


public class WallScript : MonoBehaviour
{
    public Rigidbody rB;
    public Collider wallCollision;
    public Material backWall_Mat;
    public MeshRenderer meshRenderer;

    public static int colourCount;

    private bool gotToColour1;
    private bool gotToColour2;
    private bool gotToColour3;
    private bool gotToColour4;

    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI youWin;
    public TextMeshProUGUI youLose;

    private float timer = 0f;
    private int iterations = 0;
    private float timerSpeed;
    

    private void Start()
    {
        timerSpeed = 1;
        backWall_Mat.DOColor(Color.white, .001f);
        DOTween.SetTweensCapacity(1000000, 1000000);
        finalScore.gameObject.SetActive(false);
        youLose.gameObject.SetActive(false);
        finalScore.gameObject.SetActive(false);


    }

    private void Update()
    {
        timer += timerSpeed * Time.deltaTime;
        if (timer < 2)
        {
            colourCount = 1;
            ChangeColour(); 
        }
        else if (timer < 4)
        {
            colourCount = 2;
            ChangeColour();
        }
        else if (timer < 6)
        {
            colourCount = 3;
            ChangeColour();
        }
        else if (timer < 8)
        {
            colourCount = 4;
            ChangeColour();
            iterations++;
        }
        if (timer > 8)
        {
            timer = 0;
            HUDManager.instance.DestoryInstructions();
        }

        if (iterations <= 150)
        {
            timerSpeed = 1;
        }
        if (iterations >= 300)
        {
            timerSpeed = 1.5f;
        }
        if (iterations == 600)
        {
            timerSpeed = 2;
        }
        if (Time.time > HUDManager.instance.gameTime)
        {
            colourCount = 0;
            backWall_Mat.DOColor(Color.white, 1);
            GameOver();
        }
    }

    

    private void FixedUpdate()
    {

        
        //if iteration == 1)
        //timerspeed = 1;
        // timer += timerSpeed * Time.deltaTime;
        //if(timer SMALLERTHAN 4
        //colourcount = 1;
        // else if if SMALELR THAN 8
        //couiulour cou 2
        //else if sMALL TAHN 12
        //coulour count 3
        //else if smaler than 16
        //coulur count 4
        //timer = 0f
        //iteration++;
        //if iteration == x
    }

    public void ChangeColour()
    {
        if (colourCount == 1)
        {
            backWall_Mat.DOColor(Color.yellow, 1f);
            gotToColour1 = true;
            gotToColour2 = false;
            gotToColour3 = false;
            gotToColour4 = false;
        }
        if (colourCount == 2)
        {
            backWall_Mat.DOColor(Color.red, 1f);
            gotToColour1 = false;
            gotToColour2 = true;
            gotToColour3 = false;
            gotToColour4 = false;
        }
        if (colourCount == 3)
        {
            backWall_Mat.DOColor(Color.green, 1f);
            gotToColour1 = false;
            gotToColour2 = false;
            gotToColour3 = true;
            gotToColour4 = false;
        }
        if (colourCount == 4)
        {
            backWall_Mat.DOColor(Color.blue, 1f);
            gotToColour1 = false;
            gotToColour2 = false;
            gotToColour3 = false;
            gotToColour4 = true;
        }
        //if (Time.time > 60)
        //{
        //    gotToColour4 = false;
        //}
    }
    public void GameOver()
    {
        Debug.Log("Game Over!");

        finalScoreText.gameObject.SetActive(true);
        finalScore.gameObject.SetActive(true);
        finalScore.text = Ball.points.ToString();
        HUDManager.instance.DestroyScoreText();
        HUDManager.instance.DestroyTimeElapsedText();
        if (Ball.points >= 1000)
        {
            youWin.gameObject.SetActive(true);
            Debug.Log("Player won!");
        }
        else
        {
            youLose.gameObject.SetActive(true);
            Debug.Log("Player lost!");
        }
    }
}

