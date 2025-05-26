using System;
using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class PlayerDataManager : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static PlayerDataManager instancia;

    public PlayerData datosPlayer;

    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        instancia = this;
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) QuitaVida(50f);
        //if (Input.GetKeyDown(KeyCode.S)) QuitaVida(5f);
                
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void QuitaVida(float _danno)
    {
        datosPlayer.vida -= _danno;

        Debug.Log($"El jugador esta muerto: {IsPlayerDead()}");

        if (IsPlayerDead() == true)
        {
            GameManager.instancia.CambioEstado(DataDefinitions.EstadosJuego.GameOver);
        }
        else
        {
            Debug.Log("Recibe impacto, pero sigue con vida");
        }
    }

    public void DaVida()
    {

    }

    public bool IsPlayerDead()
    {
        return datosPlayer.vida <= 0f;
    }

    public float MiMetodo(bool _param)
    {
        if (_param == true) return 1f;
        else return 0f;
    }
    #endregion
// ***********************************************
}

[Serializable]
public class PlayerData
{
    public string name;
    public float vida;
    
    public int nivel;
    public float experiencia;
    public float velocidad;
}