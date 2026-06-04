using UnityEngine;

public class GerenciadorDeSons : MonoBehaviour
{
    public static GerenciadorDeSons instance;

    public AudioSource somDaChave;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TocarSomDaChave()
    {
        somDaChave.Play();
    }
}
