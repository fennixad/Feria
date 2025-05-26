using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

[RequireComponent (typeof(AudioSource))]
public class MusicManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static MusicManager instancia;
    AudioSource audioSource;

    public AudioClip[] musicas;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        instancia = this;
        audioSource = GetComponent<AudioSource> ();
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void ReproducirMusica(int _pista, float _volumen, bool _enBucle)
    {
        // "Si (hay clip en el reproductor y ese clip es distinto al que quiero reproducir).."
        if (audioSource.clip != null && audioSource.clip != musicas[_pista])
        {
            Debug.Log("Pista nueva, se reproduce desde le principio");
            audioSource.clip = musicas[_pista];
            audioSource.loop = _enBucle;
            audioSource.volume = _volumen;
            audioSource.Play();
        }
        else
        {
            audioSource.volume = _volumen;
            Debug.Log("Pista ya en uso, se omite la reproduccion desde el principio");
        }

        if (audioSource.clip == null)
        {
            audioSource.clip = musicas[_pista];
            audioSource.loop = _enBucle;
            audioSource.volume = _volumen;

            audioSource.Play();
        }
    }

    public void CambiarVolumen(float _volumen)
    {
        audioSource.volume = _volumen;
    }
    #endregion
// ***********************************************
}
