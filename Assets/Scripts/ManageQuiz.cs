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
                    // Dodaj druge sluèajeve po potrebi
            }

            answerInput.text = "";
            feedbackText.text = "";
        }
        else
        {
            questionText.text = "The quiz is finished! Well done!";
            answerInput.gameObject.SetActive(false);
        }
    }

    string GenerateCubeQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Calculate the surface area of a cube with side length {question.dimensions[0]}.";
            case QuestionType.Volume:
                return $"Calculate the volume of a cube with side length {question.dimensions[0]}.";
            case QuestionType.DimensionCalculation:
                return $"If a cube has volume of {question.dimensions[0]}, what is the legnth of its sides?";
            default:
                return "";
        }
    }

    string GenerateSphereQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Izraèunaj površinu sfere sa polupreènikom {question.dimensions[0]}.";
            case QuestionType.Volume:
                return $"Izraèunaj volumen sfere sa polupreènikom {question.dimensions[0]}.";
            default:
                return "";
        }
    }

    string GenerateCylinderQuestionText(Question question)
    {
        switch (question.questionType)
        {
            case QuestionType.SurfaceArea:
                return $"Izraèunaj površinu cilindra sa polupreènikom {question.dimensions[0]} i visinom {question.dimensions[1]}.";
            case QuestionType.Volume:
                return $"Izraèunaj volumen cilindra sa polupreènikom {question.dimensions[0]} i visinom {question.dimensions[1]}.";
            default:
                return "";
        }
    }

    public void CheckAnswer()
    {
        string input = answerInput.text;

        if (float.TryParse(input, out float userAnswer))
        {
            if (Mathf.Approximately(userAnswer, questions[currentQuestionIndex].correctAnswer))
            {
                feedbackText.text = "Correct!";
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                feedbackText.text = "Incorrect, try again.";
            }
        }
        else
        {
            feedbackText.text = "Enter a valid number.";
        }
    }
}





