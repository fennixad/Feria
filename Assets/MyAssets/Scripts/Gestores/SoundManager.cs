using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// Gestor encargado de reproducir efectos de sonido 2D como por ejemplo pistas de audio de la interfaz (click, cancelar, etc)
/// 
/// </summary>

[RequireComponent (typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static SoundManager instancia;
    AudioSource audioSource;

    public AudioClip[] sonidos; // almacenar la pista de audio al hacer clic en un boton

    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        instancia = this;
        audioSource = GetComponent<AudioSource> ();

        Debug.Log("SoundManager listo");
    }

    private void Start()
    {

    }
    #endregion
    // ***********************************************
    #region 3) Funciones originales
    public void ReproducirSonido(int _indice)
    {
        Debug.Log("Sonido de clic");
        audioSource.PlayOneShot(sonidos[_indice]);
    }
    #endregion
// ***********************************************
}
