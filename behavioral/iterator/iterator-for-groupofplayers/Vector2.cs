class Vector2
{
    private float _x = 0;
    public float x
    {
        get { return _x; }
    }

    private float _y = 0;
    public float y
    {
        get { return _y; }
    }

    public Vector2(float x, float y)
    {
        this._x = x;
        this._y = y;
    }

    public static double Distance(Vector2 a, Vector2 b)
    {
        double result = Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2);
        return result = Math.Pow(result, 0.5f);
    }

}