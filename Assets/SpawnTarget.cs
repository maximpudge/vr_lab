using UnityEngine;
using System.Collections;

public class SpawnTarget : MonoBehaviour
{
    public GameObject prefabTarget; // Reference to the target prefab

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void NewTarget()
    {
        StartCoroutine(DelayCreate());
    }

    // Coroutine to create a new target after a delay
    private IEnumerator DelayCreate()
    {
        yield return new WaitForSeconds(2f); // Corrected from WaitForSecond to WaitForSeconds
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);
        Vector3 newPos = new Vector3(x, y, z);
        
        // Instantiate the target prefab at the new position
        Transform currentTarget = Instantiate(prefabTarget, transform.position + newPos, transform.rotation).transform;
        currentTarget.parent = transform; // Set the parent of the new target
    }
}