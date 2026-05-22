using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] int level = 0;
    [SerializeField] ParticleSystem finishEffect;

    int num_level = 2;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("Reload", 1.0f);
        }
    }
    void Reload()
    {
        SceneManager.LoadScene((level + 1)% num_level);
    }
}
