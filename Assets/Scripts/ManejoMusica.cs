using UnityEngine;
public class MusicManager : MonoBehaviour
{
    private static MusicManager instance; // Patr�n Singleton

    void Awake()
    {
        // Evita que se destruya al cargar una nueva escena
        DontDestroyOnLoad(gameObject);

        // Implementaci�n Singleton (evita duplicados)
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Destruye copias adicionales
        }
    }

}