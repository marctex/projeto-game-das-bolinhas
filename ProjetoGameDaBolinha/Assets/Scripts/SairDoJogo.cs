using UnityEngine;

public class SairDoJogo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharJogo();
        }
    }

    public void FecharJogo()
    {
        Debug.Log("O jogo está sendo fechado...");
        Application.Quit();
    }
}
