using System.Numerics;

namespace LaboratorioSistemasVivos;

public static class Matematicas2D
{
    /// <summary>
    /sin sobrepasarlo.
    /// </summary>
    public static Vector2 MoverHacia(Vector2 posicion, Vector2 objetivo, float rapidez, float dt)
    {
        Vector2 d = objetivo - posicion;
        float distancia = d.Length();
        if (distancia <= 0.0001f) return objetivo;
        Vector2 direccion = d / distancia;
        float paso = MathF.Min(rapidez * dt, distancia);
        return posicion + direccion * paso;
    }

    /// <summary>
    /// Calcula el vector unitario de dirección hacia el objetivo (0,0 si ya llegó).
    /// </summary>
    public static Vector2 CalcularDireccion(Vector2 posicion, Vector2 objetivo)
    {
        Vector2 d = objetivo - posicion;
        float distancia = d.Length();
        if (distancia <= 0.0001f) return Vector2.Zero;
        return d / distancia;
    }

    /// <summary>
    /// Convierte coordenadas de mundo (Y hacia arriba) a píxeles de pantalla (Y hacia abajo).
    /// </summary>
    public static Vector2 MundoAPantalla(Vector2 puntoMundo, Vector2 origenPantalla, float escala)
    {
        return new Vector2(
            origenPantalla.X + puntoMundo.X * escala,
            origenPantalla.Y - puntoMundo.Y * escala
        );
    }

    /// <summary>
    pantalla a coordenadas de mundo (u).
    /// </summary>
    public static Vector2 PantallaAMundo(Vector2 puntoPantalla, Vector2 origenPantalla, float escala)
    {
        return new Vector2(
            (puntoPantalla.X - origenPantalla.X) / escala,
            (origenPantalla.Y - puntoPantalla.Y) / escala
        );
    }
}
