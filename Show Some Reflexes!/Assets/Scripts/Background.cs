using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{
    float offset;

    Material currentMaterial;

    void Start ()
    {
        currentMaterial = GetComponent<Renderer>().material;
    }

    void LateUpdate ()
    {
        offset += 0.1f * Time.deltaTime;

        currentMaterial.SetTextureOffset("_MainTex", new Vector2(1f * offset, 0));
    }
}
