using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class Oleaje : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    [Range(-20f, 20f)]
    public float limiteIzq;

    [Range(-20f, 20f)]
    public float limiteDer;

    [Range(0f, 2f)]
    public float radio;

    [Range(0f, 2f)]
    public float altura;

    public float velocidad;
    public float dir;

    int modeloEscogido;

    public bool dirAleatoria;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        ComprobarDireccion();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckeoLimiteAlcanzado();
        Mover();
    }

    private void OnDrawGizmos()
    {
        Vector3 posGizmos = new Vector3 (transform.position.x, transform.position.y + altura, transform.position.z);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(posGizmos + Vector3.right * limiteDer, radio);
        Gizmos.DrawSphere(posGizmos + Vector3.right * limiteIzq, radio);
    }
    #endregion
    // ***********************************************
    #region 3) Funciones originales
    void CheckeoLimiteAlcanzado()
    {
        // "La posicion en el eje X es igual o superior al valor almacenado en la variable limite...?"
        if (transform.position.x >= limiteDer) dir = -1f;


        // "La posicion en el eje X es igual o inferior al valor almacenado en la variable limite...?"
        if (transform.position.x <= limiteIzq) dir = 1f;
    }

    void Mover()
    {
        // desplaza el objeto segun el valor de variable "velocidad" y su eje local (flecha azul)
        transform.Translate(Vector3.right * dir * velocidad * Time.deltaTime, Space.World);
    }

    void ComprobarDireccion()
    {
        if (dirAleatoria)
        {
            int random = Random.Range(0, 2); // valores posibles: 0 ó 1
            dir = random == 0 ? 1f : -1f;
        }
        else
        {
            if (dir == 0f) dir = 1f;
            else
            {
                if (dir > 0f) dir = 1f;
                else dir = -1f;
            }
        }
    }
    #endregion
    // ***********************************************
}