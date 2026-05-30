using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarDeFase : MonoBehaviour
{
    public string nomeDaProximaFase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Passei de fase");
        SceneManager.LoadScene(nomeDaProximaFase);
    }
}
