using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour

{
    // Здоровье
    int health = 5;

    // Уровень
    int level = 1;

    // Скорость
    float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Переменная Vector3
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
