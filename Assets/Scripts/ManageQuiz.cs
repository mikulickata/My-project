using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManageQuiz : MonoBehaviour
{
    public Question[] questions;
    private int currentQuestionIndex = 0;
    public TextMeshProUGUI questionText;
    public TMP_InputField answerInput; 
    public TextMeshProUGUI feedbackText;

    void Start()
    {
        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            switch (currentQuestion.shape)
            {
                case GeometricShape.Cube:
                    questionText.text = GenerateCubeQuestionText(currentQuestion);
                    break;
                case GeometricShape.Sphere:
                    questionText.text = GenerateSphereQuestionText(currentQuestion);
                    break;
                case GeometricShape.Cylinder:
                    questionText.text = GenerateCylinderQuestionText(currentQuestion);
                    break;
                    // Dodaj druge slu�ajeve po potrebi
            }

            answerInput.text = "";
            feedbackText.text = "";
        }
        else
        {
            questionText.text = "Kviz je zavr�en!";
            answerInput.gameObject.SetActive(false);
        }
    }

    string GenerateCubeQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Izra�unaj oplo�je kocke sa stranicom {question.dimensions[0]}.";
            case QuestionType.Volume:
                return $"Izra�unaj volumen kocke sa stranicom {question.dimensions[0]}.";
            case QuestionType.DimensionCalculation:
                return $"Ako kocka ima volumen {question.dimensions[0]} i jedna stranica je {question.dimensions[1]}, koliko je druga stranica?";
            default:
                return "";
        }
    }

    string GenerateSphereQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Izra�unaj povr�inu sfere sa polupre�nikom {question.dimensions[0]}.";
            case QuestionType.Volume:
                return $"Izra�unaj volumen sfere sa polupre�nikom {question.dimensions[0]}.";
            default:
                return "";
        }
    }

    string GenerateCylinderQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Izra�unaj povr�inu cilindra sa polupre�nikom {question.dimensions[0]} i visinom {question.dimensions[1]}.";
            case QuestionType.Volume:
                return $"Izra�unaj volumen cilindra sa polupre�nikom {question.dimensions[0]} i visinom {question.dimensions[1]}.";
            default:
                return "";
        }
    }

    public void CheckAnswer()
    {
        string input = answerInput.text;
        Debug.Log($"Tip answerInput.text: {input.GetType()}");

        if (float.TryParse(input, out float userAnswer))
        {
            if (Mathf.Approximately(userAnswer, questions[currentQuestionIndex].correctAnswer))
            {
                feedbackText.text = "To�no!";
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                feedbackText.text = "Neto�no, poku�aj ponovo.";
            }
        }
        else
        {
            feedbackText.text = "Unesi va�e�i broj.";
        }
        Debug.Log(answerInput.text);
        Debug.Log(float.TryParse(answerInput.text, out userAnswer));
    }
}





