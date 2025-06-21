using UnityEngine;

public class RainStarter : MonoBehaviour
{
    public ParticleSystem rainEffect;

    void Start()
    {
        Debug.Log("Intentando activar lluvia...");
        if (rainEffect != null)
        {
            rainEffect.gameObject.SetActive(true);
            rainEffect.Play();
            Debug.Log("Lluvia activada correctamente");
        }
    }
}