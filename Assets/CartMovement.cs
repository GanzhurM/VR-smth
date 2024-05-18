using UnityEngine;

public class CartMovement : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(50, 0, -9);
    public Vector3 endPosition = new Vector3(-297, 0, -9);
    public float duration = 4.0f;  // Продолжительность перемещения
    public bool Finished = false;
    private float timeElapsed = 0;

    void Start()
    {
        transform.position = startPosition;
    }
    bool move() {

        if (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / duration;
            transform.position = Vector3.Lerp(startPosition, endPosition, t);
            return false;
        }
        else
        {
            return true;
        }
    }
    void FixedUpdate()
    {
        Finished = move();
    }
};