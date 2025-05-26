using UnityEngine;

public class HudManager : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static HudManager instance;

    public RectTransform mirilla;
    public RectTransform mirillaLimite;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        MoverMirillaDentroLimites();

        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    GameManager.instancia.PausarJuego();
        //}
    }
    #endregion
    // ***********************************************
    #region 3) Funciones originales
    void MoverMirillaDentroLimites()
    {
        Vector2 localPoint;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            mirillaLimite,
            Input.mousePosition,
            null,
            out localPoint
        );

        // Tamaño del área disponible (restando el tamaño del hijo para que no sobresalga)
        Vector2 halfSize = mirilla.rect.size * 0.5f;
        Vector2 minBounds = mirillaLimite.rect.min + halfSize;
        Vector2 maxBounds = mirillaLimite.rect.max - halfSize;

        // Clampeamos la posición dentro de los límites
        localPoint.x = Mathf.Clamp(localPoint.x, minBounds.x, maxBounds.x);
        localPoint.y = Mathf.Clamp(localPoint.y, minBounds.y, maxBounds.y);

        mirilla.anchoredPosition = localPoint;
    }
    #endregion
    // ***********************************************
}
