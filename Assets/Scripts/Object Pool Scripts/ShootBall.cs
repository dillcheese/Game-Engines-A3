using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = prefab.GetComponent<Rigidbody>();
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

        ball.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * 20f;
        ball.transform.position = new Vector3(gameObject.transform.position.x + Camera.main.transform.forward.x,
            gameObject.transform.position.y + 0.5f, gameObject.transform.position.z + Camera.main.transform.forward.z);
    }
}