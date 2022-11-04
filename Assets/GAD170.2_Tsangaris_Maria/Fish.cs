using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace MariaTsangaris
{
    public enum FishList {Undefined, Dorado, Herring, Halibut, Snapper, Mullet, Tuna, Trout, Carp, Catfish, Sturgeon }
    public class Fish : MonoBehaviour
    {
        [SerializeField] private FishList chosenFish = FishList.Undefined;
        [SerializeField] private string fishName;
        [SerializeField] private string fishValue;
        [SerializeField] private string fishLength;

        public float randomFishValue;
        public float randomFishLength;
        public float addedFishValue;
        public float addedFishLength;
        public float currentChosenFish;


        public TextMeshProUGUI currentFishName;
        public TextMeshProUGUI currentFishValue;
        public TextMeshProUGUI currentFishLength;

        public GameObject eGO;
        public GameObject newFishButton;


        public void Initialize()
        {
            // We want to set up all 3 characters
            // Using an if statement, we can say:
            // Use if statements
            // if variable == 0, set up Barry Gee
            // if variable == 1, set up Peter Parker
            // if variable == 2, set up Bruce Wayne
            // if statement or
            // switch statement

            switch (chosenFish)
            {
                case FishList.Undefined:
                    Debug.Log("Fish undefined. Set its enum in the inspector!");
                    break;
                case FishList.Dorado:
                    Setup("Dorado", "5", "30");
                    break;
                case FishList.Herring:
                    Setup("Herring", "4", "25");
                    break;
                case FishList.Halibut:
                    Setup("Halibut", "12", "60");
                    break;
                case FishList.Snapper:
                    Setup("Snapper", "10", "50");
                    break;
                case FishList.Mullet:
                    Setup("Mullet", "15", "75");
                    break;
                case FishList.Tuna:
                    Setup("Tuna", "19", "90");
                    break;
                case FishList.Trout:
                    Setup("Trout", "8", "36");
                    break;
                case FishList.Carp:
                    Setup("Carp", "7", "28");
                    break;
                case FishList.Catfish:
                    Setup("Catfish", "11", "43");
                    break;
                case FishList.Sturgeon:
                    Setup("Sturgeon", "6", "40");
                    break;
                default:
                    Debug.Log("Invalid choice!");
                    break;
            }
        }

        private void Setup(string newFishName,
                           string newFishValue,
                           string newFishLength)
        {
            fishName = newFishName;
            fishValue = newFishValue;
            fishLength = newFishLength;
        }

        public void SummonFish()
        {
            currentChosenFish = Random.Range(1, 10);
            if (currentChosenFish == 1)
            {
                chosenFish = FishList.Dorado;
            }
            if (currentChosenFish == 2)
            {
                chosenFish = FishList.Herring;
            }
            if (currentChosenFish == 3)
            {
                chosenFish = FishList.Halibut;
            }
            if (currentChosenFish == 4)
            {
                chosenFish = FishList.Snapper;
            }
            if (currentChosenFish == 5)
            {
                chosenFish = FishList.Mullet;
            }
            if (currentChosenFish == 6)
            {
                chosenFish = FishList.Tuna;
            }
            if (currentChosenFish == 7)
            {
                chosenFish = FishList.Trout;
            }
            if (currentChosenFish == 8)
            {
                chosenFish = FishList.Carp;
            }
            if (currentChosenFish == 9)
            {
                chosenFish = FishList.Catfish;
            }
            if (currentChosenFish == 10)
            {
                chosenFish = FishList.Sturgeon;
            }


            randomFishValue = Random.Range(-2, 2);
            randomFishLength = Random.Range(-10, 10);
            Debug.Log(randomFishValue);
            Debug.Log(randomFishLength);

            Initialize();

            float.TryParse(fishValue, out addedFishValue);
            addedFishValue += randomFishValue;
            float.TryParse(fishLength, out addedFishLength);
            addedFishLength += randomFishLength;

            currentFishName.text = fishName;
            currentFishValue.text = addedFishValue.ToString("0");
            currentFishLength.text = addedFishLength.ToString("0");

            newFishButton.SetActive(false);

            eGO.GetComponent<Aquarium>().keepFishButton.SetActive(true);
            eGO.GetComponent<Aquarium>().releaseFishButton.SetActive(true);

            eGO.GetComponent<Aquarium>().turn += 1;
            eGO.GetComponent<Aquarium>().turns.text = eGO.GetComponent<Aquarium>().turn.ToString("0");
        }

        public void PlayAgain()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
