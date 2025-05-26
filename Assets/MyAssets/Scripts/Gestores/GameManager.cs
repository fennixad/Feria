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
    public EstadosJuego estadoActual; // contiene o almacena el estado actual del juego

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

            //
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
        CambioEstado(estadoActual);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) instancia.PausarJuego();
        
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
        CambioEstado(EstadosJuego.MenuInicial);
    }

    /// <summary>
    /// Descripcion: Asigna un nuevo estado del juego y a continuacion ejecuta ordenes asociadas
    /// al nuevo estado establecido.
    /// </summary>
    /// <param name="nuevoEstado"> Nuevo Estado que sera asignado </param>
    public void CambioEstado(EstadosJuego nuevoEstado)
    {
        estadoActual = nuevoEstado;
        Debug.Log($"Nuevo Estado: <color=yellow>{estadoActual}</color>");


        switch (estadoActual)
        {
            // *************************************************
            case EstadosJuego.Ninguno:

            break;
            // *************************************************
            case EstadosJuego.MenuInicial:
                MusicManager.instancia.ReproducirMusica(0, 1f, true);
            break;
            // *************************************************
            case EstadosJuego.Cargando:

            break;
            // *************************************************
            case EstadosJuego.Jugando:

                MusicManager.instancia.ReproducirMusica(1, 1f, true);
                Time.timeScale = 1f;
            break;
            // *************************************************
            case EstadosJuego.JuegoPausado:

                MusicManager.instancia.ReproducirMusica(1, .125f, true);
                PauseManager.instancia.VisibilidadMenuHall(true);
                Time.timeScale = 0f;
            break;
            // *************************************************
            case EstadosJuego.GameOver:

            break;
            // *************************************************
            case EstadosJuego.NivelCompletado:

            break;
            // *************************************************
        }
    }

    public void PausarJuego()
    {
        if (estadoActual == EstadosJuego.Jugando) CambioEstado(EstadosJuego.JuegoPausado);
        else if (estadoActual == EstadosJuego.JuegoPausado)
        {
            PauseManager.instancia.VisibilidadMenuHall(false);
            CambioEstado(EstadosJuego.Jugando);
        }
    }
    #endregion
    // ***********************************************
}
