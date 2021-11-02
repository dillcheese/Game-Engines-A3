using UnityEngine;

public class Bonus : MonoBehaviour
{
    public bool gotBonus = false;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //}
        //else
        //    BasicPool.Instance.AddToPool(gameObject);
        gotBonus = true;
        gameObject.SetActive(false);
       
        //Destroy(gameObject);
    }
}