using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class GameManager : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static GameManager instancia;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void CargarEscenaJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void CargarEscenaMenuInicio()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
// ***********************************************
}
