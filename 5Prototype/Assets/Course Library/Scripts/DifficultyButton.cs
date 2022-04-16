using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    public int difficutly;
    private GameManger gameManger;
    private Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManger = GameObject.Find("Game Manger").GetComponent<GameManger>();
        button.onClick.AddListener(SetDifficutly);

    }

    void SetDifficutly()
    {
        Debug.Log(button.gameObject.name + " was Clicked");
        gameManger.StartGame(difficutly);
    }

    // Update is called once per frame
    
}
