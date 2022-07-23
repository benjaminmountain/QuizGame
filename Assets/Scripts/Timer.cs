using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    bool loadNextQuestion;
    bool isAnsweringQuestion = false;
    float fillFraction;
    float timerValue;

    public bool getLoadNextQuestion() => loadNextQuestion;
    public void setLoadNextQuestion(bool newValue) => loadNextQuestion = newValue;
    public bool getIsAnsweringQuestion() => isAnsweringQuestion;
    public float getFillFraction() => fillFraction;
    void Update() {
        UpdateTimer();
    }

    public void CancelTimer() {
        timerValue = 0;
    }

    void UpdateTimer() {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion) {
            if (timerValue > 0) {
                fillFraction = timerValue / timeToCompleteQuestion;
            } else {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        } else {
            if (timerValue > 0) {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            } else {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }


}
