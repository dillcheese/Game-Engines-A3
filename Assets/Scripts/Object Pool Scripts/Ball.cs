using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
        else
            BasicPool.Instance.AddToPool(gameObject);
    }
}