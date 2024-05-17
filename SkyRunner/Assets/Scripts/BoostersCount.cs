using UnityEngine;
using UnityEngine.EventSystems;

public class BoostersCount : MonoBehaviour
{
    private TrollCounter _trollCounter;
    private void Start() => _trollCounter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TrollCounter>();

    public void ClickToBooster()
    {
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Clicker":
                _trollCounter.trollPerSecond += 1;
                _trollCounter.countTrollNow -= 20;
                break;
            case "Cursor":
                _trollCounter.trollPerClick += 1;
                _trollCounter.countTrollNow -= 150;
                break;
            case "Machonez":
                _trollCounter.trollPerSecond += 25;
                _trollCounter.countTrollNow -= 1500;
                break;
            case "Ketchup":
                _trollCounter.trollPerClick += 50;
                _trollCounter.countTrollNow -= 10000;
                break;
            case "Gycha":
                _trollCounter.trollPerSecond += 2000;
                _trollCounter.countTrollNow -= 110000;
                break;
            case "Scull":
                _trollCounter.trollPerClick += 5000;
                _trollCounter.countTrollNow -= 1000000;
                break;
            case "Scala":
                _trollCounter.trollPerSecond += 25000;
                _trollCounter.countTrollNow -= 15000000;
                break;
            case "Shrek":
                _trollCounter.trollPerClick += 50000;
                _trollCounter.countTrollNow -= 100000000;
                break;
            case "Yasher":
                _trollCounter.countTrollNow /= 2; break;
            case "Rus":
                _trollCounter.trollPerSecond += 100000;
                _trollCounter.countTrollNow -= 1000000000;
                break;
            case "Zhumaisemba":
                _trollCounter.trollPerClick += 280000;
                _trollCounter.countTrollNow -= 15000000000;
                break;
            case "Zhac":
                _trollCounter.trollPerSecond += 500000;
                _trollCounter.countTrollNow -= 50000000000;
                break;
            case "Gigachad":
                _trollCounter.trollPerClick += 10000000;
                _trollCounter.countTrollNow -= 10000000000000;
                break;
        }
    }
}
