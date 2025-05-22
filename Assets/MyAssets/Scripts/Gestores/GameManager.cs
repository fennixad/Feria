using UnityEngine;
using UnityEngine.SceneManagement;
using static DataDefinitions;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class GameManager : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static GameManager instancia;
    public EstadosJuego estadoActual;

    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        Debug.Log("Awake desde el objeto: " + gameObject.name);
        
        if (instancia == null)
        {
            Debug.Log("GameManager listo!");

            instancia = this;
            DontDestroyOnLoad(gameObject);

            transform.GetChild(0).gameObject.SetActive(true); 
        }
        else
        {
            Debug.Log("GameManager ya creado, se destruye");
            Destroy(gameObject);
        }        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start desde el objeto: " + gameObject.name);
        CambioEstado(EstadosJuego.MenuInicial);
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void CargarEscenaJugable()
    {
        SceneManager.LoadScene(1);
        CambioEstado(EstadosJuego.Jugando);
    }

    public void CargarEscenaMenuInicio()
    {
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Asigna un nuevo estado del juego y a continuacion ejecuta ordenes asociadas al nuevo estado asignado.
    /// </summary>
    /// <param name="nuevoEstado"> Nuevo Estado que sera asignado</param>
    public void CambioEstado(EstadosJuego nuevoEstado)
    {
        estadoActual = nuevoEstado;
        //Debug.Log("Nuevo Estado: " + "<color=yellow>" + estadoActual + "</color>");
        Debug.Log($"Nuevo Estado: <color=yellow>{estadoActual}</color>");

        switch (estadoActual)
        {
            case EstadosJuego.Ninguno:
                break;
            case EstadosJuego.MenuInicial:
                break;
            case EstadosJuego.Cargando:
                break;
            case EstadosJuego.Jugando:
                Time.timeScale = 1f;
                break;
            case EstadosJuego.JuegoPausado:
                Time.timeScale = 0f;
                break;
            case EstadosJuego.GameOver:
                break;
            case EstadosJuego.NivelCompletado:
                break;
        }
    }

    public void PausarJuego()
    {
        if (estadoActual == EstadosJuego.Jugando) CambioEstado (EstadosJuego.JuegoPausado);
        else if (estadoActual == EstadosJuego.JuegoPausado) CambioEstado(EstadosJuego.Jugando);
    }
    #endregion
    // ***********************************************
}
