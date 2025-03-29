using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombControl : MonoBehaviour
{
    [SerializeField] private GameObject effectPre;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("boom", 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void boom()
    {
        GameObject effect = Instantiate(effectPre, transform.position, transform.rotation);
        Destroy(effect, 2f);
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position) < 3f)
            {
                Destroy(enemy);
            }
        }
        Destroy(gameObject);
    }
}
