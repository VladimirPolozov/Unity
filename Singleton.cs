using UnityEngine;

public class Singleton : MonoBehaviour
{

    public static Singleton Instantiate;

    private void Awake()
    {
        if (Instantiate == null)
        {
            Instantiate = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    public void LogInfo()
    {
        Debug.Log(Instantiate);
    }
}