using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class MenuInicio : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables

    #endregion
// ***********************************************
    #region 2) Funciones de Unity
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
    /// <summary>
    /// Se usa en el boton "Jugar" del menu "Hall"
    /// </summary>
    public void Boton_Jugar()
    {
        Debug.Log("Click en boton Jugar");
        SoundManager.instancia.ReproducirSonido(0);
        GameManager.instancia.CargarEscenaJugable();
    }

    /// <summary>
    /// Se usa en el boton "Salir" del menu "Hall"
    /// </summary>
    public void Boton_Salir()
    {
        Debug.Log("Click en boton Salir");
        SoundManager.instancia.ReproducirSonido(1);
        Application.Quit();        
    }
    #endregion
// ***********************************************
}
