using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    public GameObject particlesDestroy; // Reference to the particle effect prefab

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obj"))
        {
            Destroy(other.gameObject); // Destroy the object that collided

            // Call NewTarget method from the SpawnTarget script
            transform.parent.GetComponent<SpawnTarget>().NewTarget();

            // Instantiate the particle effect at the current position and rotation
            Instantiate(particlesDestroy, transform.position, transform.rotation); // Corrected from Instantiaate and ratation

            Destroy(gameObject); // Destroy this target
        }
    }
}