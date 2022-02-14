using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyVector2d
{
    public float x;
    public float y;
    public MyVector2d(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public MyVector2d Add(MyVector2d other)
    {
        return this + other;
    }

    public MyVector2d Diff(MyVector2d other)
    {
        return this - other;
    }

    public MyVector2d Mul(float scalar)
    {
        return this * scalar;
    }

    public float Magn()
    {
        float result = Mathf.Sqrt(this.x * this.x + this.y * this.y);

        return result;
    }

    public MyVector2d Normalize()
    {
        float magnitude = this.Magn();

        return new MyVector2d(this.x / magnitude, this.y / magnitude);
    }

    public void Draw(MyVector2d newOrigin)
    {
        Debug.DrawLine(new Vector2(newOrigin.x, newOrigin.y), new Vector2(x + newOrigin.x, y + newOrigin.y));
    }

    public void Drawn()
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y), Color.black);
    }

    public MyVector2d Lerp(MyVector2d start, MyVector2d end, float scale)
    {
        MyVector2d c = end - start;
        c = c * scale;

        MyVector2d result = start + c;

        return result;
    }
    public static MyVector2d operator +(MyVector2d a, MyVector2d b)
    {
        return new MyVector2d(a.x + b.x, a.y + b.y);
    }
    public static MyVector2d operator -(MyVector2d a, MyVector2d b)
    {
        return new MyVector2d(a.x - b.x, a.y - b.y);
    }
    public static MyVector2d operator *(float scalar, MyVector2d a)
    {
        return new MyVector2d(a.x * scalar, a.y * scalar);
    }
    public static MyVector2d operator *(MyVector2d a, float scalar)
    {
        return new MyVector2d(a.x * scalar, a.y * scalar);
    }
    public static MyVector2d operator /(MyVector2d a, float scalar)
    {
        return new MyVector2d(a.x / scalar, a.y / scalar);
    }
}
