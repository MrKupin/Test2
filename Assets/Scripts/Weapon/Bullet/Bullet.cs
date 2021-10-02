using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    public bool IsWorking = true;

    private void OnEnable()
    {
        StartCoroutine(Disable());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Target>())
        {
            BulletCollision.Instance.Collision();
            gameObject.SetActive(false);
        }
    }


    IEnumerator Disable()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
    
}