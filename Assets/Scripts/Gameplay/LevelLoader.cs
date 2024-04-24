using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float speedToCreateThePlayer;

    static int difficulty;

    Player player1;
    Enemy enemy;
    public Enemy normalEnemy;
    public ExplodingEnemy explodingEnemy;
    // Start is called before the first frame update
    void Start()
    {
        //player1 = new Player(speedToCreateThePlayer);
        //FindObjectsOfType<Enemy>(); //This method finds all (parent/child) of type
        int result = Utilities.SumUpNumbers(2, 3);
        Debug.Log(result);
        normalEnemy = new Enemy("base name");
        explodingEnemy = new ExplodingEnemy("name");

        normalEnemy.Attack();
        explodingEnemy.Attack();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
