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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instancia = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            QuitaVida(50f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            QuitaVida(5f);
        }
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void QuitaVida(float _damage)
    {
        datosPlayer.vida -= _damage;

        if (IsPlayerDead() == true) GameManager.instancia.CambioEstado(DataDefinitions.EstadosJuego.GameOver);
        else Debug.Log("Recibe impacto, pero sigue con vida");
    }

    public void DaVida(float _vida)
    {
        datosPlayer.vida += _vida;
    }

    public bool IsPlayerDead()
    {
        return datosPlayer.vida <= 0;
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