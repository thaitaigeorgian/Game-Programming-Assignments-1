using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{

    public TextMeshProUGUI questionDisplayMeshPro;

    public QuestionSystem questionSystem;
    public GameObject[] answerBoxes;
    // Start is called before the first frame update
    void Start()
    {

        questionDisplayMeshPro.text = questionSystem.getQuestion();

        for (
            int i = 0; i < answerBoxes.Length; i++
        )
        {
            TextMeshProUGUI buttonTextMesh = answerBoxes[i].GetComponentInChildren<TextMeshProUGUI>();

            buttonTextMesh.text = questionSystem.getAnswer(i);
        }
    }

    public void OnSelectAnswer(int index)
    {
        print(index);
        if (index == questionSystem.correctAnswerIndex)
        {
            print("Correct");
            questionDisplayMeshPro.text = "Correct answer";
            Image answerImage = answerBoxes[index].GetComponent<Image>();
            if (answerImage != null)
            {
                answerImage.color = Color.red;
            }
            else
            {
                Debug.LogWarning("Image component not found on answerBox at index " + index);
            }
        }
    }
}
