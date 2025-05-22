using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

[RequireComponent (typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static SoundManager instancia;
    AudioSource audioSource;

    public AudioClip[] sonidos;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity

    private void Awake()
    {
        instancia = this;
        audioSource = GetComponent<AudioSource> ();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void ReproducirSonido(int _indice)
    {
        Debug.Log("Click en boton jugar");
        audioSource.PlayOneShot(sonidos[_indice]);
    }
    #endregion
// ***********************************************
}
