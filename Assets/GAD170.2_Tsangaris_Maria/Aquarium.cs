using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MariaTsangaris
{
    public class Aquarium : MonoBehaviour
    {
        public GameObject eGO;
        public GameObject keepFishButton;
        public GameObject releaseFishButton;
        public GameObject gameOver;

        public TextMeshProUGUI endScore;
        public TextMeshProUGUI turns;

        #region FISH
        public TextMeshProUGUI fishName1;
        public TextMeshProUGUI fishValue1;
        public TextMeshProUGUI fishLength1;
        // These are the texts for the fish kept in the Aquarium

        public TextMeshProUGUI fishName2;
        public TextMeshProUGUI fishValue2;
        public TextMeshProUGUI fishLength2;

        public TextMeshProUGUI fishName3;
        public TextMeshProUGUI fishValue3;
        public TextMeshProUGUI fishLength3;

        public TextMeshProUGUI fishName4;
        public TextMeshProUGUI fishValue4;
        public TextMeshProUGUI fishLength4;

        public TextMeshProUGUI fishName5;
        public TextMeshProUGUI fishValue5;
        public TextMeshProUGUI fishLength5;

        public TextMeshProUGUI fishName6;
        public TextMeshProUGUI fishValue6;
        public TextMeshProUGUI fishLength6;

        public TextMeshProUGUI fishName7;
        public TextMeshProUGUI fishValue7;
        public TextMeshProUGUI fishLength7;

        public TextMeshProUGUI fishName8;
        public TextMeshProUGUI fishValue8;
        public TextMeshProUGUI fishLength8;

        public TextMeshProUGUI fishName9;
        public TextMeshProUGUI fishValue9;
        public TextMeshProUGUI fishLength9;

        public TextMeshProUGUI fishName10;
        public TextMeshProUGUI fishValue10;
        public TextMeshProUGUI fishLength10;
        #endregion

        public int turn = 0;
        public int totalScore;

        public float fishSize1 = 100;
        public float fishSize2 = 100;
        public float fishSize3 = 100;
        public float fishSize4 = 100;
        public float fishSize5 = 100;
        public float fishSize6 = 100;
        public float fishSize7 = 100;
        public float fishSize8 = 100;
        public float fishSize9 = 100;
        public float fishSize10 = 100;
        // This fish length start at 100, rather than being defaulted to 0.

        public float fishSizeTest2;
        public float fishSizeTest3;
        public float fishSizeTest4;
        public float fishSizeTest5;
        public float fishSizeTest6;
        public float fishSizeTest7;
        public float fishSizeTest8;
        public float fishSizeTest9;
        public float fishSizeTest10;

        public int fishScore1;
        public int fishScore2;
        public int fishScore3;
        public int fishScore4;
        public int fishScore5;
        public int fishScore6;
        public int fishScore7;
        public int fishScore8;
        public int fishScore9;
        public int fishScore10;


        public void KeepFish()
        {
            #region Turns
            if (turn == 1)
            {
                fishName1.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue1.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength1.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue1.text, out fishScore1);
                float.TryParse(fishLength1.text, out fishSize1);
                // This turns the fish value text into an int and the fish length text into a float.
            }
            if (turn == 2)
            {
                fishName2.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue2.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength2.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue2.text, out fishScore2);
                float.TryParse(fishLength2.text, out fishSize2);
                fishSizeTest2 = fishSize2 / 2;
                if (fishSizeTest2 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                    // If the fish on the next turn (turn 2) is bigger in size than the previous fish in the aqurium it will blank out the text to "DECEASED" and remove the score.
                }
            }
            if (turn == 3)
            {
                fishName3.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue3.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength3.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue3.text, out fishScore3);
                float.TryParse(fishLength3.text, out fishSize3);
                fishSizeTest3 = fishSize3 / 2;
                if (fishSizeTest3 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest3 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                    // Turn 3 will now check if the fish is bigger in size than the rest of the fish in the aquarium.
                }
            }
            if (turn == 4)
            {
                fishName4.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue4.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength4.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue4.text, out fishScore4);
                float.TryParse(fishLength4.text, out fishSize4);
                fishSizeTest4 = fishSize4 / 2;
                if (fishSizeTest4 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest4 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest4 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
            }
            if (turn == 5)
            {
                fishName5.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue5.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength5.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue5.text, out fishScore5);
                float.TryParse(fishLength5.text, out fishSize5);
                fishSizeTest5 = fishSize5 / 2;
                if (fishSizeTest5 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest5 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest5 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest5 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
            }
            if (turn == 6)
            {
                fishName6.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue6.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength6.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue6.text, out fishScore6);
                float.TryParse(fishLength6.text, out fishSize6);
                fishSizeTest6 = fishSize6 / 2;
                if (fishSizeTest6 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest6 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest6 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest6 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
                if (fishSizeTest6 > fishSize5)
                {
                    fishName5.text = "DECEASED";
                    fishValue5.text = "";
                    fishScore5 = 0;
                    fishLength5.text = "";
                }
            }
            if (turn == 7)
            {
                fishName7.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue7.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength7.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue7.text, out fishScore7);
                float.TryParse(fishLength7.text, out fishSize7);
                fishSizeTest7 = fishSize7 / 2;
                if (fishSizeTest7 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest7 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest7 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest7 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
                if (fishSizeTest7 > fishSize5)
                {
                    fishName5.text = "DECEASED";
                    fishValue5.text = "";
                    fishScore5 = 0;
                    fishLength5.text = "";
                }
                if (fishSizeTest7 > fishSize6)
                {
                    fishName6.text = "DECEASED";
                    fishValue6.text = "";
                    fishScore6 = 0;
                    fishLength6.text = "";
                }
            }
            if (turn == 8)
            {
                fishName8.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue8.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength8.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue8.text, out fishScore8);
                float.TryParse(fishLength8.text, out fishSize8);
                fishSizeTest8 = fishSize8 / 2;
                if (fishSizeTest8 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest8 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest8 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest8 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
                if (fishSizeTest8 > fishSize5)
                {
                    fishName5.text = "DECEASED";
                    fishValue5.text = "";
                    fishScore5 = 0;
                    fishLength5.text = "";
                }
                if (fishSizeTest8 > fishSize6)
                {
                    fishName6.text = "DECEASED";
                    fishValue6.text = "";
                    fishScore6 = 0;
                    fishLength6.text = "";
                }
                if (fishSizeTest8 > fishSize7)
                {
                    fishName7.text = "DECEASED";
                    fishValue7.text = "";
                    fishScore7 = 0;
                    fishLength7.text = "";
                }
            }
            if (turn == 9)
            {
                fishName9.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue9.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength9.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue9.text, out fishScore9);
                float.TryParse(fishLength9.text, out fishSize9);
                fishSizeTest9 = fishSize9 / 2;
                if (fishSizeTest9 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest9 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest9 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest9 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
                if (fishSizeTest9 > fishSize5)
                {
                    fishName5.text = "DECEASED";
                    fishValue5.text = "";
                    fishScore5 = 0;
                    fishLength5.text = "";
                }
                if (fishSizeTest9 > fishSize6)
                {
                    fishName6.text = "DECEASED";
                    fishValue6.text = "";
                    fishScore6 = 0;
                    fishLength6.text = "";
                }
                if (fishSizeTest9 > fishSize7)
                {
                    fishName7.text = "DECEASED";
                    fishValue7.text = "";
                    fishScore7 = 0;
                    fishLength7.text = "";
                }
                if (fishSizeTest9 > fishSize8)
                {
                    fishName8.text = "DECEASED";
                    fishValue8.text = "";
                    fishScore8 = 0;
                    fishLength8.text = "";
                }
            }
            if (turn == 10)
            {
                fishName10.text = eGO.GetComponent<Fish>().currentFishName.text;
                fishValue10.text = eGO.GetComponent<Fish>().currentFishValue.text;
                fishLength10.text = eGO.GetComponent<Fish>().currentFishLength.text;
                int.TryParse(fishValue10.text, out fishScore10);
                float.TryParse(fishLength10.text, out fishSize10);
                fishSizeTest10 = fishSize10 / 2;
                if (fishSizeTest10 > fishSize1)
                {
                    fishName1.text = "DECEASED";
                    fishValue1.text = "";
                    fishScore1 = 0;
                    fishLength1.text = "";
                }
                if (fishSizeTest10 > fishSize2)
                {
                    fishName2.text = "DECEASED";
                    fishValue2.text = "";
                    fishScore2 = 0;
                    fishLength2.text = "";
                }
                if (fishSizeTest10 > fishSize3)
                {
                    fishName3.text = "DECEASED";
                    fishValue3.text = "";
                    fishScore3 = 0;
                    fishLength3.text = "";
                }
                if (fishSizeTest10 > fishSize4)
                {
                    fishName4.text = "DECEASED";
                    fishValue4.text = "";
                    fishScore4 = 0;
                    fishLength4.text = "";
                }
                if (fishSizeTest10 > fishSize5)
                {
                    fishName5.text = "DECEASED";
                    fishValue5.text = "";
                    fishScore5 = 0;
                    fishLength5.text = "";
                }
                if (fishSizeTest10 > fishSize6)
                {
                    fishName6.text = "DECEASED";
                    fishValue6.text = "";
                    fishScore6 = 0;
                    fishLength6.text = "";
                }
                if (fishSizeTest10 > fishSize7)
                {
                    fishName7.text = "DECEASED";
                    fishValue7.text = "";
                    fishScore7 = 0;
                    fishLength7.text = "";
                }
                if (fishSizeTest10 > fishSize8)
                {
                    fishName8.text = "DECEASED";
                    fishValue8.text = "";
                    fishScore8 = 0;
                    fishLength8.text = "";
                }
                if (fishSizeTest10 > fishSize9)
                {
                    fishName9.text = "DECEASED";
                    fishValue9.text = "";
                    fishScore9 = 0;
                    fishLength9.text = "";
                }
            }
            #endregion

            keepFishButton.SetActive(false);
            releaseFishButton.SetActive(false);
            // When "keep fish" button is pressed it will turn off the two buttons.
            if (turn < 10)
            {
                eGO.GetComponent<Fish>().newFishButton.SetActive(true);
                // If it is before turn 10 the "new fish" button will still appear and be active.
            }

            if (turn == 10)
            {
                gameOver.SetActive(true);
                // If it is turn 10 the game will end.

                totalScore = totalScore + fishScore1 + fishScore2 + fishScore3 + fishScore4 + fishScore5 + fishScore6 + fishScore7 + fishScore8 + fishScore9 + fishScore10;
                endScore.text = totalScore.ToString("0");
                // And will add up the value of all the fish and set it as the total score.
            }
        }

        public void ReleaseFish()
        {
            keepFishButton.SetActive(false);
            releaseFishButton.SetActive(false);
            // When "release fish" button is pressed it will turn off the two buttons.
            if (turn < 10)
            {
                eGO.GetComponent<Fish>().newFishButton.SetActive(true);
            }

            if (turn == 10)
            {
                gameOver.SetActive(true);

                totalScore = totalScore + fishScore1 + fishScore2 + fishScore3 + fishScore4 + fishScore5 + fishScore6 + fishScore7 + fishScore8 + fishScore9 + fishScore10;
                endScore.text = totalScore.ToString("0");
            }
        }

    }
}
