using UnityEngine;
using System;


[RequireComponent(typeof(Factory))]
public class Factory : MonoBehaviour
{
    private GameObject _prefab;
    public event Action OnObjectCreated;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _prefab = GetComponent<GameObject>(); // Кэширование компонента
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Objects created: ");
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            Instantiate(_prefab);
            OnObjectCreated?.Invoke();
            timer = 0f;
        }
    }
}
