using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject bombPrefab;

    private float lastTime;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = bombPrefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnBombFromPool();
        }
    }

    private void SpawnBomb()
    {
        lastTime = Time.time;

        var bomb = Instantiate(bombPrefab, gameObject.transform.position, Quaternion.identity);
    }

    private void SpawnBombFromPool()
    {
        lastTime = Time.time;

        var bullet = BasicPool.Instance.GetFromPool();
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(0f, rb.velocity.y, 12f);
        bullet.transform.position = gameObject.transform.position;
    }
}
