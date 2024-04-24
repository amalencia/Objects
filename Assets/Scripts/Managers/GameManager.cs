using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public static GameManager singleton;
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    private float timer;

    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        Instantiate(enemyPrefab);
    }

    private void Awake()
    {
        singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //StartCoroutine(SpawnEnemy());
        }
       
    }

    public void EndGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[randomIndex];

            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy(1);
        }
    }
}
