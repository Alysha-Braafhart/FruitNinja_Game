using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private float maxRotationAngle = 35f;

    private float initialZ;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
        initialZ = transform.eulerAngles.z;
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * rotationSpeed) * maxRotationAngle;
        transform.rotation = Quaternion.Euler(0f, 0f, initialZ + angle);
    }

    private System.Collections.IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
