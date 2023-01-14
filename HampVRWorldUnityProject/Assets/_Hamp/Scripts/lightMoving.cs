
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class lightMoving : UdonSharpBehaviour
{
  public float distanceToCover;
  public float speed;

    private Vector3 startingPosition;
    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        Vector3 v = startingPosition;
        v.x += distanceToCover * Mathf.Sin(Time.time * speed);
        v.y += distanceToCover * Mathf.Cos(Time.time * speed);
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;
        
    }

    
}
