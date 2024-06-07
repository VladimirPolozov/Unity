using UnityEngine;

public class Counter : MonoBehaviour
{
    private int objectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Factory factory = FindObjectOfType<Factory>();
        if (factory != null)
        {
            factory.OnObjectCreated += HandleObjectCreated;
        }
    }

    void HandleObjectCreated()
    {
        ++objectCount;
        Debug.Log("Objects created: " + objectCount);
        Singleton.Instantiate.LogInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
