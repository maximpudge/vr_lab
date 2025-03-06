using UnityEngine;

public class ParticlesDestroy : MonoBehaviour
{
    private void Start()
    {
        // Destroy this GameObject after 5 seconds
        Destroy(gameObject, 5f);
    }
}