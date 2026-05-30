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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Abre porta");
        Destroy(portaParaAbrir);
        Destroy(this.gameObject);   
    }
}
