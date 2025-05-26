using System;

[Serializable]
public static class DataDefinitions
{
    public enum EstadosJuego
    {
        Ninguno = 0, 
        MenuInicial = 1, 
        Cargando = 2, 
        Jugando = 3, 
        JuegoPausado = 4,
        GameOver = 5,
        NivelCompletado = 6
    }
}
