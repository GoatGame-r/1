using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    // npc health
    public int level = 1;
    // npc level
    public float speed = 1.2f;
    //npc speed
    public int lives;
    //declate lives;
    Vector3 newPosition;
    Transform position;
    // Start is called before the first frame update
    void Start()
    {
        lives += level;
        print(health);
        // lives = lives + level, prints health variable

    }

    // Update is called once per frame
    void Update()
    {  newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
