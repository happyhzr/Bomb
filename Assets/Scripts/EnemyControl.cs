using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < 3f)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 1f);
        }
        if (distance < 2f)
        {
            Debug.Log("Game over!");
            Time.timeScale = 0;
        }
    }
}
