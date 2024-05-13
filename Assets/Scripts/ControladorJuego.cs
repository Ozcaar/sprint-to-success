using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    private float tiempoActual;
    private bool tiempoActivado = false;
    void Start()
    {
        Activartemporizador();
    }

    void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }
    }

    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }

        if (tiempoActual < 0)
        {
            tiempoActivado = false;
            Debug.Log("Derrota");
            Activartemporizador();
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    public void Activartemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        CambiarTemporizador(true);
    }

    public void OnDestroy()
    {
        CambiarTemporizador(false);
    }
}
