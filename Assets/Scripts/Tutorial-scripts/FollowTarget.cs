using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = target.transform.position;

        transform.position = new Vector3(targetPos.x, targetPos.y, -10); ;
    }
}
