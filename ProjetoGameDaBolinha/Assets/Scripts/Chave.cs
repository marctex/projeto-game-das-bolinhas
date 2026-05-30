using System.Diagnostics;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public GameObject portaParaAbrir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        FindAnyObjectByType<GerenciadorDeSons>().TocarSomDaChave();
        Destroy(portaParaAbrir);
        Destroy(this.gameObject);   
    }
}
