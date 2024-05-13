using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etiquetas : MonoBehaviour
{
    public string nombreDeEtiqueta = "Etiqueta";
    public GameObject player;
    public GUIStyle estiloEtiqueta;

    void Start()
    {
        estiloEtiqueta = new GUIStyle();
        estiloEtiqueta.fontSize = 20;
        estiloEtiqueta.normal.textColor = Color.black;
        estiloEtiqueta.alignment = TextAnchor.MiddleCenter;
        estiloEtiqueta.fontStyle = FontStyle.Bold;
    }

    void OnGUI()
    {
        // Convertimos la posición del jugador a pantalla
        Vector3 posEnPantalla = Camera.main.WorldToScreenPoint(player.transform.position);

        // Ajustamos la posición para que la etiqueta quede arriba del jugador
        posEnPantalla.y = Screen.height - posEnPantalla.y;

        // Dibujamos la etiqueta con el estilo
        GUI.Label(new Rect(posEnPantalla.x - 50, posEnPantalla.y - 70, 100, 50), nombreDeEtiqueta, estiloEtiqueta);
    }
}
