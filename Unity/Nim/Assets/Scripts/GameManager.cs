using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] class Pile
{
    [SerializeField] public Text textbox;
    public int stones = 5;
}

public class GameManager : MonoBehaviour
{
    [SerializeField] Text instructionText;
    [SerializeField] Pile pileA;
    [SerializeField] Pile pileB;
    int moveCount = 0;

    enum gameState { playerSelectingPile, playerSelectingNumber }
    gameState currentState = gameState.playerSelectingPile;
    Pile selectedPile;  // Store reference to the pile that's been selected.

    // Start is called before the first frame update
    void Start()
    {
        instructionText.text = @"Welcome to Nim!        // @ is verbatim literal, like r''

Press the letter of the pile you want to take stones from.";
        pileA.textbox.text = "Stones in Pile A: " + pileA.stones;
        pileB.textbox.text = "Stones in Pile B: " + pileB.stones;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case gameState.playerSelectingPile:
                selectedPile = null;
                if (Input.GetKey(KeyCode.A))
                {
                    selectedPile = pileA;
                }
                if (Input.GetKey(KeyCode.B))
                {
                    selectedPile = pileB;
                    
                }
                if(selectedPile != null)
                {
                    selectedPile.textbox.color = Color.red;
                    currentState = gameState.playerSelectingNumber;
                    instructionText.text = "Now select number of stones to take: 1 or 2";
                }
                break;

            case gameState.playerSelectingNumber:
                int stonesToTake = 0;
                if (Input.GetKey(KeyCode.Alpha1))
                {
                    stonesToTake = 1;
                    moveCount++;
                }
                if (Input.GetKey(KeyCode.Alpha2))
                {
                    stonesToTake = 2;
                    moveCount++;
                }
                if(stonesToTake > 0)
                {
                    if(selectedPile.stones >= stonesToTake)
                    {
                        selectedPile.stones = selectedPile.stones - stonesToTake;
                        selectedPile.textbox.text = "Stones in pile A: " + selectedPile.stones;
                    }

                    pileA.textbox.color = Color.white;
                    pileB.textbox.color = Color.white;
                    currentState = gameState.playerSelectingPile;
                    instructionText.text = "Press the letter of the pile you want to take stones from.";
                }
                break;
        }
    }
}
