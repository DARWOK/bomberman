using UnityEngine;

public class PlayerBombManager : MonoBehaviour
{
    inputmanager InputManager;
    public GameObject bombPrefab;

    private void Awake()
    {
        InputManager = GetComponent<inputmanager>();
    }

    private void OnEnable()
    {
        InputManager.OnBombPressed.AddListener(DeployBomb);
    }

    private void OnDisable()
    {
        InputManager.OnBombPressed.RemoveListener(DeployBomb);
    }

    private void DeployBomb()
    {
        Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
