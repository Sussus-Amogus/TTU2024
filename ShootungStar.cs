using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootungStar : MonoBehaviour
{
    [SerializeField]
    private GameObject Current_Light;

    public static int Lights = 5;
    public static float Shooting_Duration = 2.0f;
    public float time;
    public float delay;
    // 設定燈光的亮度
    void Update()
    {

    }

    void Shoot()
    {
        time += Time.deltaTime;
        
        float brightness = 255f * (Mathf.Sin(time * 2 * Mathf.PI) * 0.5f + 0.5f);
        Debug.Log(brightness);
    }
}
