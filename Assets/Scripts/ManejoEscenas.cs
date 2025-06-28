using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimedSceneChange : MonoBehaviour
{
    public float sceneDuration = 5f; // Tiempo en segundos antes de cambiar
    public string nextSceneName = "NombreDeTuSiguienteEscena"; // Nombre de la escena a cargar

    void Start()
    {
        // Inicia la corrutina cuando la escena comienza
        StartCoroutine(ChangeSceneAfterTime());
    }

    IEnumerator ChangeSceneAfterTime()
    {
        // Espera el tiempo definido
        yield return new WaitForSeconds(sceneDuration);

        // Cambia a la siguiente escena
        SceneManager.LoadScene(nextSceneName);
    }
}