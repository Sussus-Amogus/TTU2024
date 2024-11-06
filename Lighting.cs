using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    [SerializeField]
    private GameObject Current_Light;

    public int Lights = 5;
    public float Start_Duration = 3.0f;
    public float Light_Duration = 2.0f;
    
    public Dictionary<string, Vector2> bezierPoints = new Dictionary<string, Vector2>()
    {
        { "P0", new Vector2(0f, 0f) },
        { "P1", new Vector2(1f, 0f) },
        { "P2", new Vector2(0f, 1f) },
        { "P3", new Vector2(1f, 1f) }
    };

    void Start()
    {
        StartCoroutine(Start_Count());
    }

    IEnumerator Start_Count()
    {
        yield return new WaitForSeconds(Start_Duration);
        StartCoroutine(Make_It_Light());
    }

    IEnumerator Make_It_Light()
    {
        for (int Lightcode = 1; Lightcode <= Lights; Lightcode++)
        {
            Current_Light = GameObject.Find(Lightcode.ToString());
            if (Current_Light != null)
            {
                SpriteRenderer spriteRenderer = Current_Light.GetComponent<SpriteRenderer>();

                if (spriteRenderer != null)
                {
                    float Light_Done = 0f;

                    while (Light_Done < Light_Duration)
                    {
                        Light_Done += Time.deltaTime;
                        float t = Light_Done / Light_Duration;
                        float bezierT = Mathf.Pow((1 - t), 3) * bezierPoints["P0"].y +
                                        3 * Mathf.Pow((1 - t), 2) * t * bezierPoints["P1"].y +
                                        3 * (1 - t) * Mathf.Pow(t, 2) * bezierPoints["P2"].y +
                                        Mathf.Pow(t, 3) * bezierPoints["P3"].y;

                        spriteRenderer.color = Color.Lerp(Color.black, Color.white, bezierT);

                        yield return null; 
                    }
                }
            }
        }
    }
}