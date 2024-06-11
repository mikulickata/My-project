using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextText : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;

    public GameObject solid;
    public GameObject planeOfTheSolid;
    public GameObject newSolid;
    public GameObject newPlaneOfTheSolid;

    //private QuizManager quizManager;

    void Start()
    {
        // Initial visibility setup
        ShowCanvas1();

        // Find the QuizManager in the scene
        // quizManager = FindObjectOfType<QuizManager>();
    }

    public void ShowCanvas1()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
        canvas3.SetActive(false);

        solid.SetActive(false);
        planeOfTheSolid.SetActive(true);
        newSolid.SetActive(false);
        newPlaneOfTheSolid.SetActive(false);
    }

    public void ShowCanvas2()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        canvas3.SetActive(false);

        solid.SetActive(true);
        planeOfTheSolid.SetActive(false);
        newSolid.SetActive(false);
        newPlaneOfTheSolid.SetActive(false);
    }

    public void ShowCanvas3()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
        canvas3.SetActive(true);

        solid.SetActive(false);
        planeOfTheSolid.SetActive(false);
        newSolid.SetActive(true);
        newPlaneOfTheSolid.SetActive(true);
    }

    public void OnNextButtonCanvas1()
    {
        ShowCanvas2();
    }

    public void OnNextButtonCanvas2()
    {
        ShowCanvas3();
    }

    public void OnPreviousButtonCanvas2()
    {
        ShowCanvas1();
    }

    public void OnPreviousButtonCanvas3()
    {
        ShowCanvas2();
    }
}
