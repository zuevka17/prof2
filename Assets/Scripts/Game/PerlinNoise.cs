using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rockPrefab;
    public GameObject platform;
    public float noiseScale = 20.0f;
    public float treeThreshold = 0.5f;
    public float rockThreshold = 0.7f;
    public float objectSpacing = 1.0f;

    private Vector3 platformMin;
    private Vector3 platformMax;

    void Start()
    {
        Collider platformCollider = platform.GetComponent<Collider>();

        platformMin = platformCollider.bounds.min + new Vector3(1, 0, 1);
        platformMax = platformCollider.bounds.max - new Vector3(1, 0, 1);

        GenerateObjects();
    }

    void GenerateObjects()
    {
        for (float x = platformMin.x; x <= platformMax.x; x += objectSpacing)
        {
            for (float z = platformMin.z; z <= platformMax.z; z += objectSpacing)
            {
                float xCoord = (x - platformMin.x) / (platformMax.x - platformMin.x) * noiseScale;
                float zCoord = (z - platformMin.z) / (platformMax.z - platformMin.z) * noiseScale;
                float sample = Mathf.PerlinNoise(xCoord, zCoord);

                Vector3 position = new Vector3(x, platformMax.y, z);

                if (sample > rockThreshold)
                {
                    Instantiate(rockPrefab, position, Quaternion.identity);
                }
                else if (sample > treeThreshold)
                {
                    Instantiate(treePrefab, position, Quaternion.identity);
                }
            }
        }
    }
}