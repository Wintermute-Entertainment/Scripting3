using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;


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

    //Tween tween1;
    //Tween tween2;
    //Tween tween3;
    //Tween tween4;

    public Text finalScore;
    public Text finalScoreText;
    public Text youWin;
    public Text youLose;

    private void Start()
    {

        backWall_Mat.DOColor(Color.white, .001f);

        DOTween.SetTweensCapacity(1000000, 1000000);

        //gotToColour4 = true;

        finalScore.gameObject.SetActive(false);
        youLose.gameObject.SetActive(false);
        finalScore.gameObject.SetActive(false);
    }

    private void Update()
    {
        //WaitForColourYellow();
        //WaitForColourRed();
        //WaitForColourGreen();
        //WaitForColourBlue();
        
    }

    private void FixedUpdate()
    {
        if (Time.time > 0 && Time.time < 4)
        {

            colourCount = 1;

        }
        if (Time.time > 4 && Time.time < 8)
        {
            colourCount = 2;
        }
        if (Time.time > 8 && Time.time < 12)
        {
            colourCount = 3;
        }
        if (Time.time > 12 && Time.time < 16)
        {
            colourCount = 4;
        }
        if (Time.time > 16 && Time.time < 20)
        {
            colourCount = 1;
        }
        if (Time.time > 20 && Time.time < 24)
        {
            colourCount = 2;
        }
        if (Time.time > 24 && Time.time < 28)
        {
            colourCount = 3;
        }
        if (Time.time > 28 && Time.time < 32)
        {
            colourCount = 4;
        }
        if (Time.time > 32 && Time.time < 34)
        {
            colourCount = 1;
        }
        if (Time.time > 34 && Time.time < 36)
        {
            colourCount = 2;
        }
        if (Time.time > 36 && Time.time < 38)
        {
            colourCount = 3;
        }
        if (Time.time > 38 && Time.time < 40)
        {
            colourCount = 4;
        }
        if (Time.time > 40 && Time.time < 42)
        {
            colourCount = 1;
        }
        if (Time.time > 42 && Time.time < 44)
        {
            colourCount = 2;
        }
        if (Time.time > 44 && Time.time < 46)
        {
            colourCount = 3;
        }
        if (Time.time > 46 && Time.time < 48)
        {
            colourCount = 4;
        }
        if (Time.time > 48 && Time.time < 49)
        {
            colourCount = 1;
        }
        if (Time.time > 49 && Time.time < 50)
        {
            colourCount = 2;
        }
        if (Time.time > 50 && Time.time < 51)
        {
            colourCount = 3;
        }
        if (Time.time > 51 && Time.time < 52)
        {
            colourCount = 4;
        }
        if (Time.time > 52 && Time.time < 53)
        {
            colourCount = 1;
        }
        if (Time.time > 53 && Time.time < 54)
        {
            colourCount = 2;
        }
        if (Time.time > 54 && Time.time < 55)
        {
            colourCount = 3;
        }
        if (Time.time > 55 && Time.time < 56)
        {
            colourCount = 4;
        }
        if (Time.time > 56 && Time.time < 57)
        {
            colourCount = 1;
        }
        if (Time.time > 57 && Time.time < 58)
        {
            colourCount = 2;
        }
        if (Time.time > 58 && Time.time < 59)
        {
            colourCount = 3;
        }
        if (Time.time > 59 && Time.time < 60)
        {
            colourCount = 4;
        }
        if (Time.time > 60)
        {
            colourCount = 0;
            backWall_Mat.DOColor(Color.white, 1);
            GameOver();
        }
        ChangeColour();
        //BackWallColourCode
        if (gotToColour1)
        {
            colourCount = 1;
            Debug.Log("Got to colour 1!");
            //gotToColour1 = true;
            //gotToColour2 = false;
            //gotToColour3 = false;
            //gotToColour4 = false;
            //WaitForColourYellow();
        }
        else if (gotToColour2)
        {
            colourCount = 2;
            Debug.Log("Got to colour 2!");
            //gotToColour1 = false;
            //gotToColour2 = true;
            //gotToColour3 = false;
            //gotToColour4 = false;
            //WaitForColourRed();
        }
        else if (gotToColour3)
        {
            colourCount = 3;
            Debug.Log("Got to colour 3!");
            //gotToColour1 = false;
            //gotToColour2 = false;
            //gotToColour3 = true;
            //gotToColour4 = false;
            //WaitForColourGreen();
        }
        else if (gotToColour4)
        {
            colourCount = 4;

            Debug.Log("Got to colour 4!");
            //gotToColour1 = false;
            //gotToColour2 = false;
            //gotToColour3 = false;
            //gotToColour4 = true;
            //WaitForColourBlue();
        }
    }
    //IEnumerator WaitForColourYellow()
    //{
    //    tween1 = backWall_Mat.DOColor(Color.yellow, 1f);
    //    yield return tween1.WaitForCompletion();
    //    // This log will happen after the tween has completed
    //    Debug.Log("Tween 1 completed!");


    //}
    //IEnumerator WaitForColourRed()
    //{
    //    tween2 = backWall_Mat.DOColor(Color.red, 1f);
    //    yield return tween2.WaitForCompletion();
    //    // This log will happen after the tween has completed
    //    Debug.Log("Tween 2 completed!");
    //}

    //IEnumerator WaitForColourGreen()
    //{
    //    tween3 = backWall_Mat.DOColor(Color.green, 1f);
    //    yield return tween3.WaitForCompletion();
    //    // This log will happen after the tween has completed
    //    Debug.Log("Tween 3 completed!");
    //}
    //IEnumerator WaitForColourBlue()
    //{
    //    tween4 = backWall_Mat.DOColor(Color.blue, 1f);
    //    yield return tween4.WaitForCompletion();
    //    // This log will happen after the tween has completed
    //    Debug.Log("Tween 4 completed!");
    //}
    public void ChangeColour()
    {
        if (colourCount == 1)
        {
            backWall_Mat.DOColor(Color.yellow, 1f);
            gotToColour1 = true;
            gotToColour2 = false;
            gotToColour3 = false;
            gotToColour4 = false;
            //WaitForColourYellow();
        }
        if (colourCount == 2)
        {
            backWall_Mat.DOColor(Color.red, 1f);
            gotToColour1 = false;
            gotToColour2 = true;
            gotToColour3 = false;
            gotToColour4 = false;
            // WaitForColourRed();
        }

        if (colourCount == 3)
        {
            backWall_Mat.DOColor(Color.green, 1f);
            gotToColour1 = false;
            gotToColour2 = false;
            gotToColour3 = true;
            gotToColour4 = false;
            //WaitForColourGreen();
        }
        if (colourCount == 4)
        {
            backWall_Mat.DOColor(Color.blue, 1f);
            gotToColour1 = false;
            gotToColour2 = false;
            gotToColour3 = false;
            gotToColour4 = true;
            //WaitForColourBlue();
        }
        if (Time.time > 60)
        {
            gotToColour4 = false;
        }
    }
    public void GameOver()
    {
        Debug.Log("Game Over!");

        finalScoreText.gameObject.SetActive(true);
        finalScore.gameObject.SetActive(true);
        finalScore.text = Ball.points.ToString();

        if (Ball.points >= 500)
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

