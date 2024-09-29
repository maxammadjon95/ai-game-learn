using UnityEngine;

public class Glowing : MonoBehaviour
{
    [Tooltip("The intensity of the glow effect")]
    public float glowIntensity = 1.0f;

    private Material material;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        float emission = Mathf.PingPong(Time.time, 1.0f) * glowIntensity;
        Color finalColor = Color.white * emission;
        material.SetColor("_EmissionColor", finalColor);
    }
}