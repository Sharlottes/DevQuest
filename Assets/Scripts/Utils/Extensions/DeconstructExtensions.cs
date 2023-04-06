using System.Collections;
using UnityEngine;

public static class Deconstructs
{
    public static void Deconstruct(this Vector3 vec3, out float x, out float y, out float z)
    {
        x = vec3.x; y = vec3.y; z = vec3.z;
    }
    public static void Deconstruct(this Vector2 vec2, out float x, out float y)
    {
        x = vec2.x; y = vec2.y;
    }
}
