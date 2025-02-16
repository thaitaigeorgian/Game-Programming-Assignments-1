using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "Question - Quiz Game", order = 0)]
public class QuestionSystem : ScriptableObject
{
    [TextArea(2, 5)][SerializeField] string questionText = "What are you doing?";

    public string[] answers = new string[4];
    public int correctAnswerIndex = 0;

    public string getQuestion()
    {
        return questionText;
    }

    public string getAnswer(int index)
    {
        return answers[index];
    }

    public string getCorrectAnswer()
    {
        return answers[correctAnswerIndex];
    }
}
