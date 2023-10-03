using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private Transform target;

    public bool canMove = false;

    public State state;

    public GameObject vfxBoom;

    private void Update()
    {
        if (canMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            float distance = Vector3.Distance(transform.position, target.position);

            if (distance <= 0.05)
            {
                canMove = false;
                GameObject vfx = Instantiate(vfxBoom, transform.position, Quaternion.identity) as GameObject;
                Destroy(vfx, 1f);

                target.GetComponent<Block>().SetState(state);

                GameManager.Instance.CheckLevelUp();

                Destroy(gameObject);
            }
        }
    }

    public void SetTarget(Transform tar)
    {
        target = tar;
        canMove = true;
    }
}
