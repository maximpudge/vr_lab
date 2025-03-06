using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject prefabObj; // Reference to the object prefab to spawn

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object has the tag "Obj"
        if (other.gameObject.CompareTag("Obj"))
        {
            // Check for other objects within a small radius
            Collider[] colls = Physics.OverlapSphere(transform.position, 0.3f);
            foreach (Collider col in colls)
            {
                // If any other object has the tag "Obj", return and do not spawn
                if (col.CompareTag("Obj"))
                {
                    return;
                }
            }

            // If no other objects are found, instantiate a new object
            Instantiate(prefabObj, transform.position, transform.rotation);
        }
    }
}