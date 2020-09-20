using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Text;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public Renderer m_Renderer;
    public Material wallMaterial;
    public GameObject wall;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    [SerializeField] float moveX;
    [SerializeField] float moveY;
    [SerializeField] float moveZ;
    [SerializeField] float moveTime;

    private string cubeColour;
    public string backColour;
    private bool backColourTrue;

    public static int points;

    private float ballYPos;

    public Text score;
    public Text timer;

    
    void Start()
    {
        ballYPos = gameObject.transform.position.y;
        wallMaterial.DOColor(Color.white, 0.5f);

        //transform.DOFlip();
        //transform.DOScale(Vector3.one, 5);
        //transform.DOPunchScale(Vector3.one * 3, 3, 3);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) { transform.DOMoveY(moveY, moveTime); }
        if (Input.GetKeyDown(KeyCode.S)) { transform.DOMoveY(-moveY, moveTime); }
        if (Input.GetKeyDown(KeyCode.D)) { transform.DOMoveX(moveX, moveTime); }
        if (Input.GetKeyDown(KeyCode.A)) { transform.DOMoveX(-moveY, moveTime); }
        if (Input.GetKeyDown(KeyCode.UpArrow)) { transform.DOMoveZ(moveZ, moveTime); }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { transform.DOMoveZ(-moveZ, moveTime); }
        if (Input.GetKeyDown(KeyCode.Space)) { ballYPos += 10; }

        
        if (cubeColour == "yellow")
        {
            if (WallScript.colourCount == 1)
            {
                backColourTrue = true;
            }
            else if (WallScript.colourCount != 1)
            {
                backColourTrue = false;
            }
        }
        if (cubeColour == "red")
        {
            if (WallScript.colourCount == 2)
            {
                backColourTrue = true;
            }
            else if (WallScript.colourCount != 2)
            {
                backColourTrue = false;
            }
        }
        if (cubeColour == "green")
        {
            if (WallScript.colourCount == 3)
            {
                backColourTrue = true;
            }
            else if (WallScript.colourCount != 3)
            {
                backColourTrue = false;
            }
        }
        if (cubeColour == "blue")
        {
            if (WallScript.colourCount == 4)
            {
                backColourTrue = true;
            }
            else if (WallScript.colourCount != 4)
            {
                backColourTrue = false;
            }
        }
         
        timer.text = Time.time.ToString();
        if (Time.time > 60)
        {
            Destroy(timer);
        }

    }
    private void FixedUpdate()
    {
        if (backColourTrue)
        {
            points += 1;
            score.text = points.ToString();
            Debug.Log("Gained 1 point.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall")) { wallMaterial.DOColor(Color.blue, 3); cubeColour = "blue"; }
        if (collision.gameObject.CompareTag("wall2")) { wallMaterial.DOColor(Color.red, 3); cubeColour = "red"; }
        if (collision.gameObject.CompareTag("wall3")) { wallMaterial.DOColor(Color.yellow, 3); cubeColour = "yellow"; }
        if (collision.gameObject.CompareTag("wall4")) { wallMaterial.DOColor(Color.green, 3); cubeColour = "green"; }
    }


}

