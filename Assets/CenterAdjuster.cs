using UnityEngine;

public class CenterAdjuster : MonoBehaviour
{
    public Vector3 offset;

    void Start()
    {
        AdjustCenter();
    }

    void AdjustCenter()
    {
        GameObject newCenter = new GameObject("NewCenter");
        newCenter.transform.position = transform.position + offset;
        transform.SetParent(newCenter.transform);
    }
}
