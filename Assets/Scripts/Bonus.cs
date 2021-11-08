using UnityEngine;

public class Bonus : MonoBehaviour
{
    public bool gotBonus = false;
    public static event System.Action<string> bonusObtain;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //}
        //else
        //    BasicPool.Instance.AddToPool(gameObject);
        gotBonus = true;
        gameObject.SetActive(false);
        bonusObtain?.Invoke(" YOU GOT THE BONUS! ");

    }
}