using UnityEngine;

public static class BasicMath
{
    public const float Rad2Deg = 57.295779513082320876798154814105f;

    public static float Magnitude(Vector2 vector)
    {
        return Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y);
    }

    public static float SqrMagnitude(Vector2 vector)
    {
        return vector.x * vector.x + vector.y * vector.y;
    }

    public static Vector2 Normalize(Vector2 vector)
    {
        return vector / Magnitude(vector);
    }

    public static Vector2 Vector2Lerp(Vector2 a, Vector2 b, float t)
    {
        t = Mathf.Clamp01(t);
        return a + t * (b - a);
    }

    public static float Dot(Vector2 a, Vector2 b)
    {
        return a.x * b.x + a.y * b.y;
    }

    public static float AngleDeg(Vector2 a, Vector2 b)
    {
        return AngleRad(Normalize(a), Normalize(b)) * Rad2Deg;
    }

    public static float AngleRad(Vector2 a, Vector2 b)
    {
        return Mathf.Acos(Dot(Normalize(a), Normalize(b)));
    }
}
