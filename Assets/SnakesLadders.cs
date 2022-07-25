using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakesLadders : MonoBehaviour {
int playerTurn;
int playerOne;
int playerTwo;
public Button btnRoll;
public Sprite one;
public Sprite two;
public Sprite three;
public Sprite four;
public Sprite five;
public Sprite six;
public Sprite normal;
public Text playerText;
public Image firstPlayer;
public Image secondPlayer;
Color blueText = new Color(0, 252, 50);

 public void Roll() {
  Button btnDice = btnRoll.GetComponent<Button>();
  int dice = UnityEngine.Random.Range(1, 6);

  if (playerTurn % 2 == 0) {

  switch (dice) {
   case 1:
    btnDice.GetComponent<Image>().sprite = one;
    playerOne = playerOne + 1;
   break;

   case 2:
    btnDice.GetComponent<Image>().sprite = two;
    playerOne = playerOne + 2;
   break;

   case 3:
    btnDice.GetComponent<Image>().sprite = three;
    playerOne = playerOne + 3;
   break;

   case 4:
    btnDice.GetComponent<Image>().sprite = four;
    playerOne = playerOne + 4;
   break;

   case 5:
    btnDice.GetComponent<Image>().sprite = five;
    playerOne = playerOne + 5;
    break;

   default:
    btnDice.GetComponent<Image>().sprite = six;
    playerOne = playerOne + 6;
   break;
   }

   switch (playerOne) {
                case 1:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -65);
                    playerOne = 38;
                    break;
                case 2:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -200);
                    break;
                case 3:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -200);
                    break;
                case 4:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -155);
                    playerOne = 14;
                    break;
                case 5:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, -200);
                    break;
                case 6:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -200);
                    break;
                case 7:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -200);
                    break;
                case 8:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -110);
                    playerOne = 30;
                    break;
                case 9:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, -200);
                    break;
                case 10:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -200);
                    break;
                case 11:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -155);
                    break;
                case 12:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, -155);
                    break;
                case 13:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, -155);
                    break;
                case 14:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -155);
                    break;
                case 15:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -155);
                    break;
                case 16:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, -155);
                    break;
                case 17:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, -155);
                    break;
                case 18:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -155);
                    break;
                case 19:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -155);
                    break;
                case 20:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, -155);
                    break;
                case 21:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -20);
                    playerOne = 42;
                    break;
                case 22:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -110);
                    break;
                case 23:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -110);
                    break;
                case 24:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, -110);
                    break;
                case 25:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, -110);
                    break;
                case 26:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -110);
                    break;
                case 27:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -110);
                    break;
                case 28:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 110); 
                    playerOne = 74;
                    break;
                case 29:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, -110);
                    break;
                case 30:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -110);
                    break;
                case 31:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -65);
                    break;
                case 32:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, -200);
                    playerOne = 10;
                    break;
                case 33:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, -65);
                    break;
                case 34:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -65);
                    break;
                case 35:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -65);
                    break;
                case 36:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -200);
                    playerOne = 6;
                    break;
                case 37:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, -65);
                    break;
                case 38:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -65);
                    break;
                case 39:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -65);
                    break;
                case 40:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, -65);
                    break;
                case 41:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, -20);
                    break;
                case 42:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, -20);
                    break;
                case 43:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -20);
                    break;
                case 44:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, -20);
                    break;
                case 45:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, -20);
                    break;
                case 46:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -20);
                    break;
                case 47:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, -20);
                    break;
                case 48:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, -110); 
                    playerOne = 26;
                    break;
                case 49:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, -20);
                    break;
                case 50:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 65);
                    playerOne = 67;
                    break;
                case 51:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, 20);
                    break;
                case 52:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 20);
                    break;
                case 53:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, 20);
                    break;
                case 54:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 20);
                    break;
                case 55:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, 20);
                    break;
                case 56:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 20);
                    break;
                case 57:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, 20);
                    break;
                case 58:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 20);
                    break;
                case 59:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, 20);
                    break;
                case 60:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, 20);
                    break;
                case 61:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, 65);
                    break;
                case 62:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, -155);
                    playerOne = 18;
                    break;
                case 63:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 65);
                    break;
                case 64:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, 65);
                    break;
                case 65:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 65);
                    break;
                case 66:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, 65);
                    break;
                case 67:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 65);
                    break;
                case 68:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, 65);
                    break;
                case 69:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 65);
                    break;
                case 70:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, 65);
                    break;
                case 71:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 200); 
                    playerOne = 92;
                    break;
                case 72:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 110);
                    break;
                case 73:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, 110);
                    break;
                case 74:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 110);
                    break;
                case 75:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, 110);
                    break;
                case 76:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 110);
                    break;
                case 77:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, 110);
                    break;
                case 78:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 110);
                    break;
                case 79:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, 110);
                    break;
                case 80:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, 200); 
                    playerOne = 99;
                    break;
                case 81:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, 155);
                    break;
                case 82:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, 155);
                    break;
                case 83:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 155);
                    break;
                case 84:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, 155);
                    break;
                case 85:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 155);
                    break;
                case 86:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(20, 155);
                    break;
                case 87:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 155);
                    break;
                case 88:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-65, -110);
                    playerOne = 24;
                    break;
                case 89:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 155);
                    break;
                case 90:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, 155);
                    break;
                case 91:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(195, 200);
                    break;
                case 92:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(155, 200);
                    break;
                case 93:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(110, 200);
                    break;
                case 94:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(65, 200);
                    break;
                case 95:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 20); 
                    playerOne = 56;
                    break;
                case 96:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-20, 200);
                    break;
                case 97:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 110);
                    playerOne = 78;
                    break;
                case 98:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-110, 200);
                    break;
                case 99:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-155, 200);
                    break;
                default:
                    firstPlayer.rectTransform.anchoredPosition = new Vector2(-195, 200);
                    break;
            }

            playerTurn++;
            playerText.GetComponent<Text>().color = blueText;
            playerText.text = "Player 2 turn";
            WinsCheck();
        }

        else if (playerTurn % 2 == 1) {
         switch (dice) {
          case 1:
           btnDice.GetComponent<Image>().sprite = one;
           playerTwo = playerTwo + 1;
          break;

          case 2:
           btnDice.GetComponent<Image>().sprite = two;
           playerTwo = playerTwo + 2;
          break;

          case 3:
           btnDice.GetComponent<Image>().sprite = three;
           playerTwo = playerTwo + 3;
          break;

          case 4:
           btnDice.GetComponent<Image>().sprite = four;
           playerTwo = playerTwo + 4;
          break;

          case 5:
           btnDice.GetComponent<Image>().sprite = five;
           playerTwo = playerTwo + 5;
          break;

          default:
           btnDice.GetComponent<Image>().sprite = six;
           playerTwo = playerTwo + 6;
          break;
         }

         switch (playerTwo) {
                case 1:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -65);
                    playerTwo = 38;
                    break;
                case 2:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -200);
                    break;
                case 3:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -200);
                    break;
                case 4:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -155);
                    playerTwo = 14;
                    break;
                case 5:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, -200);
                    break;
                case 6:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -200);
                    break;
                case 7:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -200);
                    break;
                case 8:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -110); 
                    playerTwo = 30;
                    break;
                case 9:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, -200);
                    break;
                case 10:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -200);
                    break;
                case 11:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -155);
                    break;
                case 12:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, -155);
                    break;
                case 13:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, -155);
                    break;
                case 14:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -155);
                    break;
                case 15:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -155);
                    break;
                case 16:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, -155);
                    break;
                case 17:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, -155);
                    break;
                case 18:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -155);
                    break;
                case 19:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -155);
                    break;
                case 20:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, -155);
                    break;
                case 21:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -20); 
                    playerTwo = 42;
                    break;
                case 22:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -110);
                    break;
                case 23:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -110);
                    break;
                case 24:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, -110);
                    break;
                case 25:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, -110);
                    break;
                case 26:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -110);
                    break;
                case 27:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -110);
                    break;
                case 28:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 110); 
                    playerTwo = 74;
                    break;
                case 29:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, -110);
                    break;
                case 30:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -110);
                    break;
                case 31:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -65);
                    break;
                case 32:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, -200);
                    playerTwo = 10;
                    break;
                case 33:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, -65);
                    break;
                case 34:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -65);
                    break;
                case 35:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -65);
                    break;
                case 36:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -200); 
                    playerTwo = 6;
                    break;
                case 37:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, -65);
                    break;
                case 38:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -65);
                    break;
                case 39:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -65);
                    break;
                case 40:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, -65);
                    break;
                case 41:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, -20);
                    break;
                case 42:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, -20);
                    break;
                case 43:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -20);
                    break;
                case 44:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, -20);
                    break;
                case 45:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, -20);
                    break;
                case 46:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -20);
                    break;
                case 47:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, -20);
                    break;
                case 48:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, -110); 
                    playerTwo = 26;
                    break;
                case 49:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, -20);
                    break;
                case 50:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 65); 
                    playerTwo = 67;
                    break;
                case 51:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, 20);
                    break;
                case 52:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 20);
                    break;
                case 53:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, 20);
                    break;
                case 54:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 20);
                    break;
                case 55:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, 20);
                    break;
                case 56:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 20);
                    break;
                case 57:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, 20);
                    break;
                case 58:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 20);
                    break;
                case 59:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, 20);
                    break;
                case 60:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, 20);
                    break;
                case 61:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, 65);
                    break;
                case 62:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, -155);
                    playerTwo = 18;
                    break;
                case 63:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 65);
                    break;
                case 64:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, 65);
                    break;
                case 65:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 65);
                    break;
                case 66:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, 65);
                    break;
                case 67:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 65);
                    break;
                case 68:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, 65);
                    break;
                case 69:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 65);
                    break;
                case 70:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, 65);
                    break;
                case 71:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 200); 
                    playerTwo = 92;
                    break;
                case 72:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 110);
                    break;
                case 73:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, 110);
                    break;
                case 74:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 110);
                    break;
                case 75:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, 110);
                    break;
                case 76:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 110);
                    break;
                case 77:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, 110);
                    break;
                case 78:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 110);
                    break;
                case 79:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, 110);
                    break;
                case 80:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, 200); 
                    playerTwo = 99;
                    break;
                case 81:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, 155);
                    break;
                case 82:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, 155);
                    break;
                case 83:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 155);
                    break;
                case 84:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, 155);
                    break;
                case 85:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 155);
                    break;
                case 86:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(20, 155);
                    break;
                case 87:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 155);
                    break;
                case 88:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-65, -110);
                    playerTwo = 24;
                    break;
                case 89:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 155);
                    break;
                case 90:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, 155);
                    break;
                case 91:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(195, 200);
                    break;
                case 92:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(155, 200);
                    break;
                case 93:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(110, 200);
                    break;
                case 94:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(65, 200);
                    break;
                case 95:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 20);
                    playerTwo = 56;
                    break;
                case 96:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-20, 200);
                    break;
                case 97:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 110); 
                    playerTwo = 78;
                    break;
                case 98:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-110, 200);
                    break;
                case 99:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-155, 200);
                    break;
                default:
                    secondPlayer.rectTransform.anchoredPosition = new Vector2(-195, 200);
                    break;
            }

            playerTurn++;
            playerText.GetComponent<Text>().color = Color.red;
            playerText.text = "Player 1 turn";
            WinsCheck();
        }
    }

    void Start() {
     playerTurn = 0;
     playerOne = 0;
     playerTwo = 0;
    }

    public void WinsCheck() {
    Button btnDice = btnRoll.GetComponent<Button>();

    if (playerOne >= 100) {
    playerText.GetComponent<Text>().color = Color.red;
    playerText.text = "Player 1 wins";
    btnDice.enabled = false;
    }

    else if (playerTwo >= 100) {
    playerText.GetComponent<Text>().color = blueText;
    playerText.text = "Player 2 wins";
    btnDice.enabled = false;
    }
    }

    public void Restart() {
    Button btnDice = btnRoll.GetComponent<Button>();
    btnDice.enabled = true;
    btnDice.GetComponent<Image>().sprite = normal;
    playerTurn = 0;
    playerOne = 0;
    playerTwo = 0;
    firstPlayer.rectTransform.anchoredPosition = new Vector2(-235, -200);
    secondPlayer.rectTransform.anchoredPosition = new Vector2(-270, -200);
    }
}
