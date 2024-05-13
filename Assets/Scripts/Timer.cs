using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f; // Tiempo inicial
    public Text timeText; // Referencia al objeto de texto

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // Reducir el tiempo restante
            UpdateTimerDisplay(); // Actualizar la visualización del temporizador
        }
        else
        {
            // Acciones al llegar a cero el temporizador, por ejemplo, game over
            Debug.Log("Time's up!");
        }
    }
    void UpdateTimerDisplay()
    {
        // Convertir el tiempo restante a formato de minutos y segundos
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        // Actualizar el texto del temporizador
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
