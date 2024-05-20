using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextText : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;

    public GameObject cube;
    public GameObject planeOfTheCube;
    public GameObject newCube;
    public GameObject newPlaneOfTheCube;

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

        cube.SetActive(true);
        planeOfTheCube.SetActive(false);
        newCube.SetActive(false);
        newPlaneOfTheCube.SetActive(false);
    }

    public void ShowCanvas2()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        canvas3.SetActive(false);

        cube.SetActive(false);
        planeOfTheCube.SetActive(true);
        newCube.SetActive(false);
        newPlaneOfTheCube.SetActive(false);
    }

    public void ShowCanvas3()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
        canvas3.SetActive(true);

        cube.SetActive(false);
        planeOfTheCube.SetActive(false);
        newCube.SetActive(true);
        newPlaneOfTheCube.SetActive(true);
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
