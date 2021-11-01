using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [SerializeField]
    private GameObject bombPrefab;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = bombPrefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootBallFromPool();
        }
    }

    private void ShootBallFromPool()
    {
        var ball = BasicPool.Instance.GetFromPool();
        ball.GetComponent<Rigidbody>().velocity = new Vector3(0f, rb.velocity.y, 12f);
        ball.transform.position = gameObject.transform.position;
    }
}