using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class PauseManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static PauseManager instancia;

    public GameObject menuHall;

    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        instancia = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void VisibilidadMenuHall (bool _esVisible)
    {
        if (menuHall != null) menuHall.SetActive(_esVisible);
    }

    #region 3.2) FUNCIONALIDAD BOTONES
    public void Boton_Continuar()
    {
        Debug.Log("Click en boton Continuar");
        SoundManager.instancia.ReproducirSonido(0);
        GameManager.instancia.PausarJuego();
    }

    public void Boton_Reiniciar()
    {
        Debug.Log("Click en boton Reiniciar");
        SoundManager.instancia.ReproducirSonido(0);
        GameManager.instancia.CargarEscenaJugable();
    }

    public void Boton_Salir()
    {
        Debug.Log("Click en boton Salir");
        SoundManager.instancia.ReproducirSonido(0);
        GameManager.instancia.CargarEscenaMenuInicio();
    }
    #endregion
    #endregion
    // ***********************************************
}
