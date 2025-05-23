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

    public AudioClip[] music;

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
        // "Si (hay clip en el reproductor y ese clip es distinto al que quiero reproducir)..."
        if (audioSource.clip != null && audioSource.clip == music[_pista])
        {
            Debug.Log("Piesta nueva, se reproduce desde el principio");
            audioSource.clip = music[_pista];
            audioSource.loop = _enBucle;
            audioSource.volume = _volumen;
            audioSource.Play();
        }
        else
        {
            audioSource.volume = _volumen;
            Debug.Log("Piesta en uso, se omite la reproduccion desde el principio");
        }

        if (audioSource.clip == null)
        {
            audioSource.clip = music[_pista];
            audioSource.loop = _enBucle;
            audioSource.volume = _volumen;
            audioSource.Play();
        }

    }
    #endregion
// ***********************************************
}
